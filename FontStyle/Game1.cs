using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FontStyle
{
	/// <summary>
	/// ゲームメインクラス
	/// </summary>
	public class Game1 : Game
	{
    /// <summary>
    /// グラフィックデバイス管理クラス
    /// </summary>
    private readonly GraphicsDeviceManager _graphics = null;

    /// <summary>
    /// スプライトのバッチ化クラス
    /// </summary>
    private SpriteBatch _spriteBatch = null;

    /// <summary>
    /// デフォルトフォント
    /// </summary>
    private SpriteFont _defaultFont = null;

    /// <summary>
    /// フォント名変更フォント
    /// </summary>
    private SpriteFont _fontNameFont = null;

    /// <summary>
    /// サイズ変更フォント
    /// </summary>
    private SpriteFont _sizeFont = null;

    /// <summary>
    /// 文字間変更フォント
    /// </summary>
    private SpriteFont _spacingFont = null;

    /// <summary>
    /// 太字フォント
    /// </summary>
    private SpriteFont _boldFont = null;

    /// <summary>
    /// イタリックフォント
    /// </summary>
    private SpriteFont _italicFont = null;

    /// <summary>
    /// カーニングOFFフォント
    /// </summary>
    private SpriteFont _kerningOffFont = null;

    /// <summary>
    /// デフォルト文字フォント
    /// </summary>
    private SpriteFont _defaultCharacterFont = null;


    /// <summary>
    /// GameMain コンストラクタ
    /// </summary>
    public Game1()
    {
      // グラフィックデバイス管理クラスの作成
      _graphics = new GraphicsDeviceManager(this);

      // ゲームコンテンツのルートディレクトリを設定
      Content.RootDirectory = "Content";

      // マウスカーソルを表示
      IsMouseVisible = true;
    }

    /// <summary>
    /// ゲームが始まる前の初期化処理を行うメソッド
    /// グラフィック以外のデータの読み込み、コンポーネントの初期化を行う
    /// </summary>
    protected override void Initialize()
    {
      // TODO: ここに初期化ロジックを書いてください

      // コンポーネントの初期化などを行います
      base.Initialize();
    }

    /// <summary>
    /// ゲームが始まるときに一回だけ呼ばれ
    /// すべてのゲームコンテンツを読み込みます
    /// </summary>
    protected override void LoadContent()
    {
      // テクスチャーを描画するためのスプライトバッチクラスを作成します
      _spriteBatch = new SpriteBatch(GraphicsDevice);

      // フォントをコンテンツパイプラインから読み込む
      _defaultFont = Content.Load<SpriteFont>("Default");
      _fontNameFont = Content.Load<SpriteFont>("FontName");
      _sizeFont = Content.Load<SpriteFont>("Size");
      _spacingFont = Content.Load<SpriteFont>("Spacing");
      _boldFont = Content.Load<SpriteFont>("Bold");
      _italicFont = Content.Load<SpriteFont>("Italic");
      _kerningOffFont = Content.Load<SpriteFont>("KerningOff");
      _defaultCharacterFont = Content.Load<SpriteFont>("DefaultCharacter");
    }

    /// <summary>
    /// ゲームが終了するときに一回だけ呼ばれ
    /// すべてのゲームコンテンツをアンロードします
    /// </summary>
    protected override void UnloadContent()
    {
      // TODO: ContentManager で管理されていないコンテンツを
      //       ここでアンロードしてください
    }

    /// <summary>
    /// 描画以外のデータ更新等の処理を行うメソッド
    /// 主に入力処理、衝突判定などの物理計算、オーディオの再生など
    /// </summary>
    /// <param name="gameTime">このメソッドが呼ばれたときのゲーム時間</param>
    protected override void Update(GameTime gameTime)
    {
      // ゲームパッドの Back ボタン、またはキーボードの Esc キーを押したときにゲームを終了させます
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
      {
        Exit();
      }

      // TODO: ここに更新処理を記述してください

      // 登録された GameComponent を更新する
      base.Update(gameTime);
    }

    /// <summary>
    /// 描画処理を行うメソッド
    /// </summary>
    /// <param name="gameTime">このメソッドが呼ばれたときのゲーム時間</param>
    protected override void Draw(GameTime gameTime)
    {
      // 画面を指定した色でクリアします
      GraphicsDevice.Clear(Color.CornflowerBlue);

      // スプライトの描画準備
      _spriteBatch.Begin();

      // デフォルト
      _spriteBatch.DrawString(_defaultFont, "Sample Text -Default-",
          new Vector2(20.0f, 20.0f), Color.White);

      // カーニング OFF
      _spriteBatch.DrawString(_kerningOffFont, "Sample Text -Kerning OFF-",
          new Vector2(20.0f, 70.0f), Color.White);

      // フォント名
      _spriteBatch.DrawString(_fontNameFont, "Sample Text -FontName-",
          new Vector2(20.0f, 120.0f), Color.White);

      // フォントサイズ
      _spriteBatch.DrawString(_sizeFont, "Sample Text -Size-",
          new Vector2(20.0f, 170.0f), Color.White);

      // 文字間
      _spriteBatch.DrawString(_spacingFont, "Sample Text -Spacing-",
          new Vector2(20.0f, 220.0f), Color.White);

      // 太字
      _spriteBatch.DrawString(_boldFont, "Sample Text -Bold-",
          new Vector2(20.0f, 270.0f), Color.White);

      // イタリック
      _spriteBatch.DrawString(_italicFont, "Sample Text -Italic-",
          new Vector2(20.0f, 320.0f), Color.White);

      // デフォルト文字
      _spriteBatch.DrawString(_defaultCharacterFont, "Sample Text -デフォルト文字-",
          new Vector2(20.0f, 370.0f), Color.White);

      // スプライトの一括描画
      _spriteBatch.End();

      // 登録された DrawableGameComponent を描画する
      base.Draw(gameTime);
    }
  }
}
