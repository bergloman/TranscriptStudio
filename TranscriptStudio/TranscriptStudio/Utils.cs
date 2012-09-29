using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranscriptStudio {

    public static class SchemaUtils {

        public static string FromDoubleToTimeStr(this double val) {
            var val_ms = (int)Math.Floor(1000 * val % 1000);
            var val_s = (int)Math.Floor(val % 60);
            var val_m = (int)Math.Floor(val / 60) % 60;
            var val_h = (int)Math.Floor(val / 60 / 60);
            return string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", val_h, val_m, val_s, val_ms);
        }
    }
}
