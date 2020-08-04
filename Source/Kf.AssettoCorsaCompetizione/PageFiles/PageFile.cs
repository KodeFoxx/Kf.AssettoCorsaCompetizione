using Kf.Essentials.CleanArchitecture.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles
{
    public abstract class PageFile<TData> : ValueObject
    {
        public string Location { get; }
        protected MemoryMappedFile File { get; private set; }
        protected TData Data { get; set; }

        public PageFile(string location)
            => Location = location;

        public (bool Success, PageFileConnectionError ErrorInfo) Connect()
        {
            var pageFileConnectionError = PageFileConnectionError.None;

            try {
                File = MemoryMappedFile.OpenExisting(Location);                
            } catch (DirectoryNotFoundException directoryNotFoundException)
            {
                pageFileConnectionError = new PageFileConnectionError(
                    $"Page file '{Location}' not found, see innerException for more details.",
                    directoryNotFoundException
                );
            }
            catch (FileNotFoundException fileNotFoundException) {
                pageFileConnectionError = new PageFileConnectionError(
                    $"Page file '{Location}' not found, see innerException for more details.",
                    fileNotFoundException
                );
            } catch(Exception exception) {
                pageFileConnectionError = new PageFileConnectionError(
                    $"Could not connect to page file '{Location}', see innerException for more details.",
                    exception
                );
            }

            if (pageFileConnectionError == PageFileConnectionError.None)
                return (true, pageFileConnectionError);

            return (false, pageFileConnectionError);
        }

        protected override IEnumerable<object> EquatableValues
            => new object[] { Location, File };

        public void RefreshData()
            => Read();

        protected TData Read()
        {
            if (File == null) return default;      
            
            using(var viewStream = File.CreateViewStream())
            {
                using(var binaryReader = new BinaryReader(viewStream))
                {
                    var size = Marshal.SizeOf<TData>();
                    var bytes = binaryReader.ReadBytes(size);
                    var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                    Data = Marshal.PtrToStructure<TData>(handle.AddrOfPinnedObject());
                    handle.Free();

                    return Data;
                }
            }
        }
    }
}
