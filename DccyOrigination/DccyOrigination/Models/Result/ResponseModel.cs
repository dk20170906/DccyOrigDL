using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DccyOrigination.Models.Result
{
    public class ResponseModel
    {
        private WebHeaderCollection header;
        /// <summary>
        /// 返回的头部信息集合
        /// </summary>
        public WebHeaderCollection Header
        {
            get { return header; }
            set { header = value; }
        }
        private string html;
        /// <summary>
        /// 返回的文本内容
        /// </summary>
        public string Html
        {
            get { return html; }
            set { html = value; }
        }
        private Stream stream;
        /// <summary>
        /// 返回的流内容
        /// </summary>
        public Stream Stream
        {
            get { return stream; }
            set { stream = value; }
        }

    }
}
