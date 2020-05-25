using System.Collections.Generic;
namespace DSS_Platform_DotNetSDK.Lib.Models.Resp {
    public class AcsCardSyncPageModel {
        public long? currentPage { get; set; }
        public long? pageSize { get; set; }
        public long? totalPage { get; set; }
        public long? totalRows { get; set; }

        public List<AcsCardSyncModel> pageData { get; set; }
    }
}