using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelamentoConstrucao.Application {
    public static class ApplicationLibrary {
        public static DBValues DBValues => DBTranspiler.DBValues;
        public static DBTranspiler DBTranspiler { get; set; }
    }
}
