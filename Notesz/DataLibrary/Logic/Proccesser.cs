using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using DataLibrary.DataAccess;

namespace DataLibrary.Logic
{
    public static class Proccesser
    {
        public static int createNote(string cim, string tartalom)
        {
            DBNoteModel data = new DBNoteModel {cim = tartalom, 
            tartalom = tartalom
            };
            string sql = @"insert into dbo.Note (cim, tartalom) values (@cim, @tartalom);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<DBNoteModel> LoadNote()
        {
            string sql = @"select cim, tartalom from dbo.Note;";
            return SqlDataAccess.LoadData<DBNoteModel>(sql);
        }
    }
}
