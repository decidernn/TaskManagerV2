﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Task_Manager
{
    class WordHelper
    {
        FileInfo _fileInfo;

        public WordHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }

        }

        public bool process(Dictionary<string, string> items, string fileName)
        {
            try
            {
                var app = new Word.Application();
                Object file = _fileInfo.FullName;


                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;


                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                //Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString(DateTime.Now.ToString("ddMmMyyyy HHmmss")) + _fileInfo.Name);

                app.ActiveDocument.SaveAs2(fileName);
                app.ActiveDocument.Close();
                app.Quit();


                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
