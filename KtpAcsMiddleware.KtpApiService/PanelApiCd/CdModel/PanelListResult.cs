﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtpAcsMiddleware.KtpApiService.PanelApiCd.CdModel
{
     public class PanelListResult: CdResult
    {
       
        public List<PanelUserInfo> data { get; set; }
    }
}
