# PlaybackCue
Unity 2017.1 のTimelineでとりあえずADX2LEのキューを鳴らすサンプル

## Timelineでの使い方
### 1.TimlineのAddで「Playback Cue Track」でトラックを作成する。
### 2.右クリックで「Add Playback Cue Clip Clip」を選択する。

- トラックにCriAtomSourceをセットする。
- Clipにキュー名を指定する。

## 仕様：
- アプリケーション実行時にしか再生しません。（エディターのプレビューでは音は出ない）
- 現状一つのトラックで一つの音のみ再生可能。
- 再生停止後にもClipがあると、もう一度再生してしまう。
- Clipの範囲を超えても音が停止しない。停止していない場合次のClipの再生は無効。
