﻿using System;
using System.Collections.Generic;
using Kasi.Tools.Harvester.Domain.Abstract.Repository;
using Kasi.Tools.Harvester.Domain.Concrete.Entity;

namespace Kasi.Tools.Harvester.Domain.Concrete.Repository
{
    public class FileSystemRepo : IFileSystemRepo<FileSystemRecord>
    {
        public IEnumerable<FileSystemRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<FileSystemRecord> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public FileSystemRecord GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public FileSystemRecord GetBySha1Hash(string hash)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileSystemRecord> GetSome(Func<FileSystemRecord, bool> filter, int skip, int take)
        {
            throw new NotImplementedException();
        }
    }
}
