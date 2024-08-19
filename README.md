# 部活の新入部員とシューティングゲームを作るプロジェクト

## システム
* 横スクロール
* 敵・攻撃に当たるとダメージ
* 倒した敵・ボスと戦った時間に応じてスコア上昇

## プレイヤー操作
* 十字移動
* 押している間攻撃
* アイテム(触った瞬間使用)

## 敵
* 流れてくるだけのやつ
* 玉打ってくるやつ
* 少し進んで戻ったり変な動きをする奴

## ボス
* 弱点以外無効
* 雑魚呼び
* レーザー
* 体当たり

## 利用アセット
* [Warped Shooting Fx](https://assetstore.unity.com/packages/2d/textures-materials/abstract/warped-shooting-fx-195246)
* [2D Pixel Spaceship - Two Small Ships](https://assetstore.unity.com/packages/2d/characters/2d-pixel-spaceship-two-small-ships-131545)
* [2D Space Kit](https://assetstore.unity.com/packages/2d/environments/2d-space-kit-27662)
* [Space Star Field Backgrounds](https://assetstore.unity.com/packages/2d/textures-materials/space-star-field-backgrounds-109689)
* [2D Simple UI Pack](https://assetstore.unity.com/packages/2d/gui/icons/2d-simple-ui-pack-218050)

# TODOリスト

- [ ] playerの基本動作実装
   - [x] 移動機能実装
   - [x] カメラ内に移動範囲を制限
   - [x] カメラロール実装
   - [ ] 攻撃機能実装
   - [ ] 弾が移動する実装
   - [ ] ダメージ用インターフェースをプレイヤーに実装
- [ ] 敵の実装
   - [ ] 敵(何もしない)実装
   - [ ] 弾を打つ敵
   - [ ] 敵の玉
   - [ ] 動く敵
- [ ] ゲームマネージャー
   - [ ] スコア機能
   - [ ] ボスイベント
- [ ] ボスの実装
   - [ ] ステートマシンの作成
   - [ ] 装甲(弱点以外を守る役割)
   - [ ] 雑魚呼び
   - [ ] レーザー
   - [ ] 体当たり
