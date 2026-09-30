//using Design_Patterns;
//using Design_Patterns.Memento;
//using System.ComponentModel.DataAnnotations;

//var editor = new Editor();
//var history = new History();

//editor.setContent("a");
//history.push(editor.CreateState());

//editor.setContent("b");
//history.push(editor.CreateState());

//editor.setContent("c");
//editor.restoreState(history.pop());
//editor.restoreState(history.pop());

//Console.WriteLine(editor.getContent());


//using Design_Patterns.State;

//var canvas = new Canves();

//canvas.setTool(new SelectionTool());
//canvas.MouseDown();
//canvas.MouseUp();

//using Design_Patterns.State.Abuse;

//var stopWatch = new StopWatch();
//stopWatch.Click();
//stopWatch.Click();
//stopWatch.Click();

//using Design_Patterns.State.Abuse;

//var stopWatch = new StopWatch(null);
//stopWatch.setState(new RunningState(stopWatch));
//stopWatch.Click();
//stopWatch.Click();
//stopWatch.Click();

//using Design_Patterns.State.EX;

//var dirServices = new DirectionService();
//dirServices.setTravelMode(new BicycleState());
//dirServices.getEta();

//dirServices.setTravelMode(new DrivingState());
//dirServices.getDirection();

//using Design_Patterns.Iterator;

//var history = new BrowserHistory();

//history.push("a");
//history.push("b");
//history.push("c");


//var iterator = history.createList();

//while(iterator.hasNext())
//{
//    Console.WriteLine(iterator.current());
//    iterator.next();
//}

//using Design_Patterns.Iterator.EX;
//var p1 = new Product(1, "Amer");
//var p2 = new Product(2, "Ali");

//var product = new ProductCollection();

//product.add(p1);
//product.add(p2);

//var iterator = product.createProduct();

//while(iterator.hasNext())
//{
//    Console.WriteLine(iterator.current());
//    iterator.next();
//}

//using Design_Patterns.Strategy;

//var storageImage = new StorageImage(new PngCompressor(), new BlackAndWhiteFilter());

//storageImage.store("a");


//using Design_Patterns.Strategy;

//var storageImage = new StorageImage();

//storageImage.store("a", new PngCompressor(), new BlackAndWhiteFilter());

//using Design_Patterns.Strategy.EX;

//var client =new ChatClient(new AesEncryptionAlgorithm());

//client.send("Hello World");

//using Design_Patterns.Template;

//var taskMoney = new TransferMoneyTask();
//taskMoney.execute();

//using Design_Patterns.Template.EX;

//var window = new ChartWindow();
//window.close();
//using Design_Patterns.Command;
//using Design_Patterns.Command.Fx;

//var services = new CustomerServices();
//var command = new AddCustomerCommand(services);
//var button = new Button(command);
//button.click();

//var composite = new CompositeCommand();
//composite.AddCommand(new ResizeCommand(new Resize()));
//composite.AddCommand(new BlackAndWhitCommand(new BlackAndWhite()));
//composite.AddCommand(command);
//composite.execute();

//using Design_Patterns.Command.Editor;

//var html = new HtmlDocument();
//var html2 = new HtmlDocument();
//var history = new History();
//var history2 = new History();
//var bold = new BoldCommand(history, html);
//var bold2 = new BoldCommand(history2, html2);

//html.setContent("hello world");
//bold.execute();
//html2.setContent("hello");
//bold2.execute();

//Console.WriteLine(html.getContent() );
//Console.WriteLine(html2.getContent() );

//var undo = new UndoCommand(history);
//var undo2 = new UndoCommand(history2);
//undo.execute();
//undo2.execute();

//Console.WriteLine(html.getContent());
//Console.WriteLine(html2.getContent());


//using Design_Patterns.Command.EX;

//var videoEditor = new VideoEditor();
//var history = new History();

//var setTextCommand = new SetTextCommand(history , videoEditor , "Video Title");
//setTextCommand.execute();
//Console.WriteLine("TEXT: " + videoEditor);

//var setContrast = new SetContrastCommand(1, history , videoEditor );
//setContrast.execute();
//Console.WriteLine("CONTRAST: " + videoEditor);

//var undoCommand = new UndoCommand(history);
//undoCommand.execute();
//Console.WriteLine("UNDO: " + videoEditor);

//undoCommand.execute();
//Console.WriteLine("UNDO: " + videoEditor);

//undoCommand.execute();
//Console.WriteLine("UNDO: " + videoEditor);


//using Design_Patterns.Observer;

//var dataSource = new DataSource();
//var sheet = new SpreedSheet(dataSource);
//var sheet2 = new SpreedSheet(dataSource);
//var chart = new Chart(dataSource);
//dataSource.Add(sheet);
//dataSource.Add(sheet2);
//dataSource.Add(chart);


//dataSource.setValue(1);

//using Design_Patterns.Observer.EX;

//var statusBar = new StatusBar();
//var stockListView = new StockListView();

//var stock1 = new Stock("stock1", 10);
//var stock2 = new Stock("stock2", 20);
//var stock3 = new Stock("stock3", 30);

//// The status bar shows the popular stocks
//statusBar.addStock(stock1);
//statusBar.addStock(stock2);

//// The stock view list shows all stocks
//stockListView.addStock(stock1);
//stockListView.addStock(stock2);
//stockListView.addStock(stock3);

//// Causes both statusBar and stockListView to get refreshed
//stock2.setPrice(21);

//// Causes only the stockListView to get refreshed. (statusBar
//// is not watching this stock.)
//stock3.setPrice(9);

//using Design_Patterns.Mediator;

//var articalDialogBox = new ArticalDialogBox();
//articalDialogBox.simulateUserInteraction();

//using Design_Patterns.Mediator.EX;

//var registerDilogBox = new RegisterDilogBox();
//registerDilogBox.simulateUserInteraction();

//using Design_Patterns.Chain_Of_Responsbility;

//var compress = new Compressor(null);
//var log = new Logger(compress);
//var encrypt = new Encryptor(log);
//var auth = new Authenticator(encrypt);
//var webServer = new WebServer(auth);
//webServer.handle(new HttpRequest("Admin", "1234"));


//var excel = new Excel(null);
//var number = new Numbers(excel);
//var qbook = new QuickBooks(number);
//var dataReader = new DataReader(qbook);
//dataReader.read("ali.qbw");
//dataReader.read("ali.numbers");
//dataReader.read("ali.xls");
//dataReader.read("ali.qbw");

//using Design_Patterns.Chain_Of_Responsbility.EX;

//var reader = DataReaderFactory.getDataReaderChain();
//reader.handle("data.xls");
//reader.handle("data.numbers");
//reader.handle("data.qbw");
//reader.handle("data.jpg");

//using Design_Patterns.Visitor;

//var html = new HtmlDocument();
//html.Add(new AnchorNode());
//html.Add(new HeadingNode());


//html.execute(new HighLigthOperation());
//html.execute(new PlainTextOperation());

//using Design_Patterns.Visitor.EX;

//var wavFile = WavFile.read("myfile.wav");
//wavFile.execute(new NoiseReductionFilter());
//wavFile.execute(new ReverbFilter());
//wavFile.execute(new NormalizeFilter());





