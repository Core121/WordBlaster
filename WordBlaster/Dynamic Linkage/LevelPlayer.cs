using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBlaster.Dynamic_Linkage
{
    public class LevelPlayer //Singleton
    {
        private static LevelPlayer myInstance = new LevelPlayer();
        private LevelPlayer() { }
        private string file;
        public static LevelPlayer getInstance()
        {
            return myInstance;
        } // getInstance()
        public void getDynamicFile()
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                this.file = path;
            }
        }

        public string getFile()
        {
            return file;
        }
    }
}
