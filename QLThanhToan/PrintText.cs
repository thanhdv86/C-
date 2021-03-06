using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;

namespace QLThanhToan
{
    class PrintText: PrintDocument
    {
        string[] textDocument;//Chứa nội dung tài liệu cần in

        public string[] TextDocument
        {
            get { return textDocument; }
            set { textDocument = value; }
        }
        int pageNumber = 0; //Số trang đang được in

        public int PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        int lineNumber = 0;// Số dòng được in

        public int LineNumber
        {
            get { return lineNumber; }
            set { lineNumber = value; }
        }
        public PrintText(string[] _textDocument)
        {
            this.TextDocument = _textDocument;
        }
    }
}
