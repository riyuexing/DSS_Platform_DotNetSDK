using System.Collections.Generic;
using DSS_Platform_DotNetSDK.Lib.Models.Req.Base;
using Newtonsoft.Json;

namespace DSS_Platform_DotNetSDK.Lib.Models.Req {
    public class ApiQuery {
        public ApiQuery (string interfaceId) {
            this.interfaceId = interfaceId;
            Param = new BaseParam ();
        }

        public ApiQuery () {
            Param = new BaseParam ();
        }

        public ApiQuery (string interfaceId, BaseParam param, string jsonParam) {
            this.interfaceId = interfaceId;
            this.Param = param;
            this.jsonParam = jsonParam;

        }
        public string interfaceId { get; set; }
        public BaseParam Param { get; set; }

        public string jsonParam { get; set; }

        /*
                public ApiQuery AddPara(string key, object value)
                {
                    this.Param.param.Add(key, value);
                    return this;
                }

                */

        public string ToJosnString () {
            /*System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions();
            options.IgnoreNullValues = true;
            jsonParam = System.Text.Json.JsonSerializer.Serialize(Param, options);
            Param = null;
            return System.Text.Json.JsonSerializer.Serialize(this, options);*/
            Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings ();
            settings.NullValueHandling = NullValueHandling.Ignore;
            jsonParam = Newtonsoft.Json.JsonConvert.SerializeObject (this.Param, settings);
            Param = null;
            return Newtonsoft.Json.JsonConvert.SerializeObject (this, settings);
        }
    }

}