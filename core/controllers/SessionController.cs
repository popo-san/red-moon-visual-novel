using core.data;
using core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.controllers
{
    public class SessionController
    {

        //public static SessionModel create()
        //{
        //}

        public static async System.Threading.Tasks.Task<List<SessionModel>> findAll()
        {
            return await DatabaseConnection.findAll<SessionModel>(); ;
        }

        //public static SessionModel findBySessionID(int sessionID)
        //{
        //}

        //public static SessionModel save(SessionModel currentSession)
        //{
        //}

        private SessionController()
        {
        }

    }
}
