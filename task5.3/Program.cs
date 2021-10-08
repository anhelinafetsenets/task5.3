using System;

namespace task5._3
{
    class Path
    {
        private string filepath;
        private string rootfolder;
        private string filename;

        public Path(string path)
        {
            this.filepath = path;
            string[] subs = path.Split("\\");
            this.rootfolder = subs[0];
            string[] sub2 = subs[subs.Length - 1].Split(".");
            this.filename = sub2[0];
        }

        public override string ToString()
        {
            return $@"Full path: {filepath} Root folder: {rootfolder} Files name: {filename}";
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Path a = new Path(Console.ReadLine());
            Console.WriteLine(a);
        }
    }
}
