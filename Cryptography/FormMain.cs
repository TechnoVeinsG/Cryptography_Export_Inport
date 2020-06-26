///
/// 非対称鍵ジェネレータ および 暗号文の復号処理サンプル
/// 
/// Copyright (c) 2020 Techno Veins Co.,Ltd.
/// 
/// This software is released under the MIT License.
/// http://opensource.org/licenses/mit-license.php
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// "公開鍵を作成する" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// キーコンテナ内に指定した名称で秘密鍵と公開鍵のペアが作成、保管されます
        /// 公開鍵をファイルに書き出す例です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGeneratekey_Click(object sender, EventArgs e)
        {
            //　CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            //　CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // SaveFileDialog オブジェクト作成
            SaveFileDialog sfd = new SaveFileDialog();
            // ファイル名の初期値を指定する
            sfd.FileName = "public_key.xml";
            // 選択肢を指定する
            sfd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            //タイトルを設定する
            sfd.Title = "保存する公開鍵のファイルを選択してください。";
            // ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            // 既に存在するファイル名を指定したとき警告する
            sfd.OverwritePrompt = true;
            // 存在しないパスが指定されたとき警告を表示する
            sfd.CheckPathExists = true;
            // ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // ファイルに書き込む
                using (Stream stream = sfd.OpenFile())
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(rsa.ToXmlString(false));
                }
            }
        }

        /// <summary>
        /// "キーコンテナからエクスポートする" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// キーコンテナ内に指定した名称で秘密鍵と公開鍵のペアが作成、保管されます
        /// 非対称鍵ペアをファイルに書き出す例です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            // CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            // CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // SaveFileDialog オブジェクト作成
            SaveFileDialog sfd = new SaveFileDialog();
            // ファイル名の初期値を指定する
            sfd.FileName = "private_key.xml";
            // 選択肢を指定する
            sfd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            // タイトルを設定する
            sfd.Title = "保存する秘密鍵のファイルを選択してください。";
            // ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            // 既に存在するファイル名を指定したとき警告する
            sfd.OverwritePrompt = true;
            // 存在しないパスが指定されたとき警告を表示する
            sfd.CheckPathExists = true;
            // ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // ファイルに書き込む
                using (Stream stream = sfd.OpenFile())
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(rsa.ToXmlString(true));
                }
            }
        }

        /// <summary>
        /// "キーコンテナから削除する" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// キーコンテナ内に指定した名称で秘密鍵と公開鍵のペアが作成、保管されます
        /// キーコンテナに保管されている非対称鍵ペアを削除する例です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            // CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            //キーコンテナを削除
            rsa.PersistKeyInCsp = false;
            rsa.Clear();
        }

        /// <summary>
        /// "キーコンテナにインポートする" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// エクスポートされた非対称鍵ペアファイルを指定した名前で、キーコンテナにインポートする例です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInport_Click(object sender, EventArgs e)
        {
            // CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            // CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // OpenFileDialog オブジェクト作成
            OpenFileDialog ofd = new OpenFileDialog();
            // ファイル名の初期値を指定する
            ofd.FileName = "private_key.xml";
            // 選択肢を指定する
            ofd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            // タイトルを設定する
            ofd.Title = "インポートする秘密鍵のファイルを選択してください。";
            // ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            // ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 非対称鍵ペアをインポート
                rsa.FromXmlString(File.ReadAllText(ofd.FileName));
            }
        }

        /// <summary>
        /// "復号 ↑" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// textBoxのBase64形式に変換された暗号文を復号し、textBoxにセットする例です
        /// 平文のキャラクタセットはUTF-8です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            // CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            // CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // base64化暗号文をデコードして暗号文バイト列
            byte[] bytEncrypted = System.Convert.FromBase64String(textBoxCryptogram.Text);
            // 暗号文バイト列を復号して平文バイト列
            byte[] bytPlain = rsa.Decrypt(bytEncrypted, false);
            // 平文バイト列を文字列に変換して表示
            textBoxPlaintext.Text = System.Text.Encoding.UTF8.GetString(bytPlain);
        }

        /// <summary>
        /// "暗号化 ↓" ボタンが押されたときの処理
        /// </summary>
        /// <remarks>
        /// 以下の例では、キーコンテナを使用しています
        /// textBoxの平文を暗号化し、Base64形式に変換してtextBoxにセットする例です
        /// 平文のキャラクタセットはUTF-8です
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            // CspParametersオブジェクトの作成
            CspParameters cp = new CspParameters();
            // キーコンテナを参照するときの名前を指定する
            cp.KeyContainerName = textBoxKeyContainer.Text;
            // CspParametersを指定してRSACryptoServiceProviderオブジェクトを作成
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // 平文文字列を平文バイト列に変換
            byte[] bytPlain = System.Text.Encoding.UTF8.GetBytes(textBoxPlaintext.Text);
            // 平文バイト列を暗号化して暗号文バイト列にセット
            byte[] bytEncrypted = rsa.Encrypt(bytPlain, false);
            // 暗号文バイト列をbase64文字列に変換して表示
            textBoxCryptogram.Text = System.Convert.ToBase64String(bytEncrypted);
        }
    }
}
