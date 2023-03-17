# RTG-MatchResults-MarketData
Script to convert a match result file into a market data file

Remove first line: "Time,Competitor,Operation,OrderId,Instrument,Side,Volume,Price,Lifespan,Fee" from your match result file
Run the script
Then add "Time,Instrument,Operation,OrderId,Side,Volume,Price,Lifespan" as the first line of the newly created market data file

You can now use this market data to test your autotrader 
