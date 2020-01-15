import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandleGraphComponent } from './Components/candle-graph/candle-graph.component';
import { BotViewComponent } from './Pages/bot-view/bot-view.component';
import { CandleSignalRClassicService } from './Services/CandleSignalR/candle-signal-r-classic.service';
import { CandleSignalRService } from './Services/CandleSignalR/candle-signal-r.service';

@NgModule({
  declarations: [
    AppComponent,
    CandleGraphComponent,
    BotViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    {
      provide: CandleSignalRService,
      useClass: CandleSignalRClassicService
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
