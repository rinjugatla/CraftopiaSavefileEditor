# Craftopiaセーブデータ編集/移行ツール

## シームレスアップデートの対応

  こちらのアプリはシームレスアップデートに対応していません。
  
  シームレスアップデート後のセーブデータの編集は以下のリポジトリを参照してください。
  
  https://github.com/rinjugatla/CraftopiaSavefileEditorWeb

## Craftopiaセーブデータ編集ツール

### 概要

  クラフトピアのセーブデータ(ocsファイル)を編集するためのツールです。

### 注意

  ご利用は自己責任でお願いします。
  
  誤った書式に編集するとセーブデータが破損する恐れがあります。
  
  事前にバックアップをとることを強く推奨します。
  
### セーブデータ

  Steam版Craftopiaのセーブデータは以下に保存されます。
  
  `C:\Users\%username%\AppData\LocalLow\PocketPair\Craftopia\Save`

### 機能

  現在2つの機能を実装しています。
  それぞれツール上部のタブから操作を切り替えます。

#### OCS<->JSON変換

  OCSファイルをJSONファイルに、JSONファイルをOCSファイルに変換する機能です。  
  OCSファイルからJSONファイルを作成したい場合は「JSONに変換」にOCSファイルをドラッグアンドドロップします。  
  ファイルは複数個同時に読み込むことが出来ます。

  ドラッグアンドドロップで読み込まれたファイルをそれぞれ同じ位置にJSONファイルとして書き出します。  
  例えば、`/Save/Players/test.ocs`を変換すると`/Save/Players/test.json`が作成されます。

  JSONファイルからOCSファイルを作成する場合も同様の手順になります。

#### OCS手動編集

  OCSファイルをテキストエディタから編集する機能です。

  OCSの読み込み方は3通りあります。

  1. 画面上部のテキストボックスにファイルパスを直接入力し、「開く」ボタンを押下します。  
  2. 「参照」ボタンを押下し、OCSファイルを選択します。  
  3. OCSファイルをテキストエリアにドラッグアンドドロップします。  
  
  OCSを編集した後は「保存」ボタンを押下します。  
  「保存」ボタンを押下しない限りはファイルを保存しませんのでご注意ください。

### NuGetパッケージ

  本ツールは以下のNuGetパッケージを利用しています。

* ScintillaNET
https://github.com/VPKSoft/ScintillaNET/blob/master/LICENSE

* ScintillaNET-FindReplaceDialog
https://github.com/VPKSoft/ScintillaNET-FindReplaceDialog/blob/master/LICENSE

* Jil
https://github.com/kevin-montrose/Jil/blob/master/LICENSE

* Windows-API-Code-Pack-1.1
https://github.com/aybe/Windows-API-Code-Pack-1.1/blob/master/LICENCE

## Craftopia新旧セーブデータ移行ツール

### 概要

  クラフトピアの新旧セーブデータを移行するツールです。

### 注意

  ご利用は自己責任でお願いします。

  セーブデータが標準の保存位置に存在する前提で動作します。  
  動作には以下のファイル構成が必要です。

  1. ゲームで読み込まれるセーブフォルダ `PocketPair\Craftopia\Save`  
  2. 新形式移行時に旧セーブデータがバックアップされるフォルダ `PocketPair\Craftopia\OldSaveData\Save`
  
### セーブデータ

  Steam版Craftopiaのセーブデータは以下に保存されます。
  
  `C:\Users\%username%\AppData\LocalLow\PocketPair\Craftopia\Save`

### 機能

  現在のセーブデータの形式を新旧で判別します。
  旧形式のデータと新形式のデータを入れ替えます。

#### 新/旧移行

  ツール起動後、有効になっている「移行」ボタンを押下します。  
  正常に移行できた場合は、完了通知を表示し、セーブファイルの状態を再取得します。  
  失敗した場合はエラーメッセージを表示します。

### NuGetパッケージ

  本ツールは以下のNuGetパッケージを利用しています。

* Jil
https://github.com/kevin-montrose/Jil/blob/master/LICENSE
