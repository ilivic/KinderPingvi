using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingvinMaster.ADOApp;

namespace PingvinMaster.ClassApp
{
    /// <summary>
    /// публичный класс для харения данных о авторизовавшемся пользователе
    /// </summary>
    public class CorrUserClass
    {
        /// <summary>
        /// публичная переменная для хранения записи о авторизовавшемся пользователе
        /// </summary>
        public static Users CorrUser { get; set; }
    }
}
