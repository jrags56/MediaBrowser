﻿using MediaBrowser.Controller.Sync;
using MediaBrowser.Model.Querying;
using MediaBrowser.Model.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBrowser.Server.Implementations.Sync
{
    public class SyncManager : ISyncManager
    {
        private ISyncProvider[] _providers = new ISyncProvider[]{};

        public void AddParts(IEnumerable<ISyncProvider> providers)
        {
            _providers = providers.ToArray();
        }

        public Task<List<SyncJob>> CreateJob(SyncJobRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<SyncSchedule> CreateSchedule(SyncScheduleRequest request)
        {
            throw new NotImplementedException();
        }

        public QueryResult<SyncJob> GetJobs(SyncJobQuery query)
        {
            throw new NotImplementedException();
        }

        public QueryResult<SyncSchedule> GetSchedules(SyncScheduleQuery query)
        {
            throw new NotImplementedException();
        }

        public Task CancelJob(string id)
        {
            throw new NotImplementedException();
        }

        public Task CancelSchedule(string id)
        {
            throw new NotImplementedException();
        }

        public SyncJob GetJob(string id)
        {
            throw new NotImplementedException();
        }

        public SyncSchedule GetSchedule(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SyncTarget> GetSyncTargets()
        {
            return _providers.SelectMany(i => i.GetSyncTargets());
        }
    }
}