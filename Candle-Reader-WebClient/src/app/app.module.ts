import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandleGraphComponent } from './Components/candle-graph/candle-graph.component';
import { BotViewComponent } from './Pages/bot-view/bot-view.component';
import { CandleSignalRClassicService } from './Services/CandleSignalR/candle-signal-r-classic.service';
import { CandleSignalRService } from './Services/CandleSignalR/candle-signal-r.service';
import { CandleSignalRMockService } from './Services/CandleSignalR/candle-signal-r-mock.service';
import { CandleGraphTradingViewComponent } from './Components/candle-graph-trading-view/candle-graph-trading-view.component';
import { CandleFunctionsService } from './Services/CandleFunctions/candle-functions.service';
import { BrokerComponent } from './Pages/broker/broker.component';
import { IdeDirective } from './Directives/Ide/ide.directive';
import { ToolBoxButtonComponent } from './Components/tool-box-button/tool-box-button.component';

@NgModule({
  declarations: [
    AppComponent,
    CandleGraphComponent,
    BotViewComponent,
    CandleGraphTradingViewComponent,
    BrokerComponent,
    IdeDirective,
    ToolBoxButtonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    CandleFunctionsService,
    {
      provide: CandleSignalRService,
      useClass: CandleSignalRClassicService
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
