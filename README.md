# What is this
OpenBankingGateway .Net connectors generated using OpenAPI generator.


# Connector list
 - [csharp-netcore/obg-api](csharp-netcore/obg-api) C# .Net core


# How to generate
## Requirements
1. Java 8+ to run generator


## Generation
Run `generate-connector.sh`, it will download recent API version from OBG GitHub and
create API clients(s) in [csharp-netcore/obg-api](csharp-netcore/obg-api) folder.
(Default API branch source - develop)


# OpenBankingGateway call sequence

The sequence diagram to get transaction list from OpenBankingGateway
![Session diagram](http://www.plantuml.com/plantuml/proxy?src=https://raw.githubusercontent.com/valb3r/obg-connectors.net/master/obg-call-sequence.puml&fmt=svg&vvv=1&sanitize=true)


# OpenBankingGateway Postman collection call sequence

You can use this [Postman collection](https://github.com/adorsys/open-banking-gateway#postman-scripts-to-play-with-api) 
to see the sequence of calls done to get users' accounts from OBG (Note this requires request signing disabled).