﻿using SWD.SmartThrive.Services.Model;

namespace SWD.SmartThrive.Services.Services.Interface
{
    public interface ISessionService
    {

        public Task<bool> AddSession(SessionModel session);
        public Task<bool> UpdateSession(SessionModel session);
        public Task<bool> DeleteSession(Guid id);

        public Task<SessionModel> GetSession(Guid id);

        public Task<IEnumerable<SessionModel>> GetAllSessionByCourse(Guid courseid);

        public Task<IEnumerable<SessionModel>> GetAllSessions();


    }
}