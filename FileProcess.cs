﻿using System;
using System.IO;

namespace FileFolderIOSample
{
    class FileProcess
    {
        public void FileIO()
        {
            var file = new FileInfo(@"C:\SampleData\sample.txt");

            //情報取得系
            //ファイルが存在するか
            Console.WriteLine(file.Exists);

            //ファイル名
            Console.WriteLine(file.Name);

            //フォルダ名
            Console.WriteLine(file.DirectoryName);

            //読み取り専用か
            Console.WriteLine(file.IsReadOnly);

            //最終アクセス日時を取得
            Console.WriteLine(file.LastAccessTime);

            //最終更新日を取得
            Console.WriteLine(file.LastWriteTime);

            //サイズを取得
            Console.WriteLine(file.Length);


            //操作系
            //ブレイクポイント入れてステップ実行しながら見ると動きがわかる
            //今の状態だと一瞬で終わる

            //ファイルのコピー(第2引数は上書きするか)
            var file2 = file.CopyTo(@"C:\SampleData\sample_Copy.txt", true);

            //ファイルを移動
            file2.MoveTo(@"C:\SampleData\deep\sample_Copy.txt");

            //ファイルを消去
            file2.Delete();

            Console.ReadLine();
        }
    }
}