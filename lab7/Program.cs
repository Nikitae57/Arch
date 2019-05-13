using System;
using Microsoft.Office.Interop.Word;

namespace lab7 {
	internal class Program {
		
		private ApplicationClass app = new ApplicationClass();
		private Document doc;
		
		object fileName = @"D:\otchet.docx";
		object readOnly = false;
		object isVisible = true;
		object missing = System.Reflection.Missing.Value;

		public static void Main(string[] args) {
			new Program().go();
		}

		private void go() {
			doc = app.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
				ref missing, ref missing, 
				ref readOnly, ref missing, ref 
				missing, ref missing, ref missing,
				ref missing, ref missing, ref missing, 
				ref missing, ref missing);
			
			doc.Activate();

			if (doc.Bookmarks.Exists("subject")) {
				object oBookMark = "subject";
				doc.Bookmarks.get_Item(ref oBookMark).Range.Text = "Использование COM объектов";
			}
			
			if (doc.Bookmarks.Exists("date")) {
				object oBookMark = "date";
				doc.Bookmarks.get_Item(ref oBookMark).Range.Text = DateTime.Now.ToString("M/d/yyyy");
			}
			
			if (doc.Bookmarks.Exists("discipline")) {
				object oBookMark = "discipline";
				doc.Bookmarks.get_Item(ref oBookMark).Range.Text = "Проектированaие и архитектура программных систем";
			}
			
			if (doc.Bookmarks.Exists("teachers")) {
				object oBookMark = "teachers";
				doc.Bookmarks.get_Item(ref oBookMark).Range.Text = "Ужаринский А.Ю., Константинов И.С.";
			}
			
			app.Documents.Save(ref missing, ref missing);
			app.Application.Quit(ref missing, ref missing, ref missing);
		}
	}
}