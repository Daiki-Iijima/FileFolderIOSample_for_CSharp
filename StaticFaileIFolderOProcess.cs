﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileProcessSample
{
    class StaticFaileIFolderOProcess
    {
        public void StaticFaileIFolderIO()
        {
            //静的クラスなのでインスタンスの生成をしない

            //======ファイル操作=======

            //ファイルがあるか確認
            Console.WriteLine(File.Exists(@"C:\SampleData\sample.txt"));

            //ファイルのコピー
            //第３引数は上書きするか
            File.Copy(@"C:\SampleData\sample.txt", @"C:\SampleData\sample_Copy.txt", true);
            
            //ファイルの移動
            File.Move(@"C:\SampleData\sample_Copy.txt", @"C:\SampleData\deep\sample_Copy.txt");
            
            //ファイルの名前を変更
            File.Move(@"C:\SampleData\deep\sample_Copy.txt", @"C:\SampleData\deep\RenameSample_Copy.txt");
            
            //ファイルの消去
            File.Delete(@"C:\SampleData\deep\RenameSample_Copy.txt");


            //======フォルダ操作======

            //フォルダの作成
            Directory.CreateDirectory(@"C:\SampleData\createFolder");

            //フォルダ名の変更
            Directory.Move(@"C:\SampleData\createFolder", @"C:\SampleData\Rename_createFolder");

            //フォルダの移動
            Directory.Move(@"C:\SampleData\Rename_createFolder", @"C:\SampleData\deep\Rename_createFolder");

            //フォルダの消去
            Directory.Delete(@"C:\SampleData\deep\Rename_createFolder");
        }

    }
}
