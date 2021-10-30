# CraftopiaSavefileEditor

## 概要

  クラフトピアのセーブデータ(ocsファイル)を編集するためのツールです。

## 注意

  ご利用は自己責任でお願いします。
  誤った書式に編集するとセーブデータが破損する恐れがあります。
  事前にバックアップをとることを強く推奨します。
  
## セーブデータ

  Steam版Craftopiaのセーブデータは以下に保存されます。
  
  `C:\Users\%username%\AppData\LocalLow\PocketPair\Craftopia\Save`

## 機能

  現在2つの機能を実装しています。
  それぞれツール上部のタブから操作を切り替えます。

### OCS<->JSON変換

  OCSファイルをJSONファイルに、JSONファイルをOCSファイルに変換する機能です。
  OCSファイルからJSONファイルを作成したい場合は「JSONに変換」にOCSファイルをドラッグアンドドロップします。
  ファイルは複数個同時に読み込むことが出来ます。

  ドラッグアンドドロップで読み込まれたファイルをそれぞれ同じ位置にJSONファイルとして書き出します。
  例えば、`/Save/Players/test.ocs`を変換すると`/Save/Players/test.json`が作成されます。

  JSONファイルからOCSファイルを作成する場合も同様の手順になります。

### OCS手動編集

  OCSファイルをテキストエディタから編集する機能です。

  OCSの読み込み方は3通りあります。
    * 画面上部のテキストボックスにファイルパスを直接入力し、「開く」ボタンを押下します。
    * 「参照」ボタンを押下し、OCSファイルを選択します。
    * OCSファイルをテキストエリアにドラッグアンドドロップします。
  
  OCSを編集した後は「保存」ボタンを押下します。
  「保存」ボタンを押下しない限りはファイルを保存しませんのでご注意ください。


## NuGetパッケージ

本ツールは以下のNuGetパッケージを利用しています。

* ScintillaNET
https://github.com/VPKSoft/ScintillaNET/blob/master/LICENSE

* ScintillaNET-FindReplaceDialog
https://github.com/VPKSoft/ScintillaNET-FindReplaceDialog/blob/master/LICENSE
