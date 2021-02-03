using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace core.models
{
    [Table("SESSION")]
    public class SessionModel
    {

        [PrimaryKey]
        [Column("SESSION_ID")]
        public int SessionID { get; set; }

        [Column("SESSION_NAME")]
        public string SessionName { get; set; }

    }
}
