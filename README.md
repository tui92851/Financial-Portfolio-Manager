# Financial-Portfolio-Manager

### Table of Contents

[ Project Abstract ](#abstract)

[ High Level Requirement ](#high-level)

[ Conceptual Design ](#design)

[ Background ](#background)

[ Required Resources ](#resources)



<a name="abstract"></a>
## Project Abstract
This software will allow an individual to add of their investment accounts into a single GUI for easier managment and tracking capapbilities.  Along with allowing a user to view all of their portfolios, the Financial Portfolio Manager will use an API to pair with TradingView for buy/sell indicators for the assets in all of your portoflios. TradingView indicators can be coded in Pine Script and will allow each individual to customize which indicators are visisble to them. 

<a name="high-level"></a>
## High Level Requirement
This software is to be coded in C# and use the Windows .NET Framework libraries.  The graphical user interface will be designed in Visual Studio using the components provided by the .NET libraries.  The portfolio manager will extend a TradingView Javascript API that will need to be hosted (https://github.com/Mathieu2301/TradingView-API) and this will be used for pulling data on specific assets, along with displaying the status of the indicators which can be added by the user.  TradingView scripts for buying and selling (https://www.tradingview.com/scripts/buy-sell/) are coded in Pine Script, but for the initial development of the project free indicators will be used for making sure they are properly displaying.  For adding accounts they will be imported through a text document (WEBSITE:USER:PASS), and depending on the website each account will have to be logged into different.  Some accounts will require 2FA, or email verification which a design for each will need to be created.  

<a name="design"></a>
## Conceptual Design
The Financial Portfolio Manager will be ran only on the Windows opearting system using the .NET framework for its graphical user interface components.  It will display the assets for each investment account that the user adds to it.  The image attached below is the beta design of the Graphical User Interface and shows all of the assets in the top data grid view, and shows your tradingview buy/sell indicators in the bottom data grid view.  


<img src="https://i.imgur.com/QxRU2II.png" width="60%">


<a name="background"></a>
## Background

<a name="resources"></a>
## Required Resources
