﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFolderIOSample
{
    class FolderProcess
    {

        public void FolderIO()
        {
            var dir = new DirectoryInfo(@"C:\SampleData\deep");
            
            //情報取得系
            //フォルダが存在するか
            Console.WriteLine(dir.Exists);

            //フォルダーの親フォルダーを取得
            Console.WriteLine(dir.Parent);

            //フォルダーのルートを取得
            Console.WriteLine(dir.Root);

            //フォルダの作成日時
            Console.WriteLine(dir.CreationTime);
            
            //フォルダの最終アクセス日時
            Console.WriteLine(dir.LastAccessTime);

            //フォルダの最終更新日
            Console.WriteLine(dir.LastWriteTime);

            //サブフォルダの一覧を取得
            //===サブフォルダを絞り込みたい場合===
            //dir.GetDirectories("xxx*");  //xxxが先頭につくフォルダのみを取得可能
            var dirs = dir.GetDirectories();
            foreach(var child in dirs)
            {
                Console.WriteLine(child.FullName);
            }

            //フォルダの作成
            var dir2 = new DirectoryInfo(@"C:\SampleData\Newdeep");
            dir2.Create();

            //フォルダ名の変更
            dir2.MoveTo(@"C:\SampleData\RenameNewdeep");

            //フォルダの移動
            dir2.MoveTo(@"C:\SampleData\deep\RenameNewdeep");

            //サブフォルダの作成
            dir2.CreateSubdirectory("sub");

            //フォルダの消去
            //引数で「true」を指定しない場合指定のフォルダの配下にフォルダ、ファイルがあった場合エラーになる
            dir2.Delete(true);
        }

    }
}
