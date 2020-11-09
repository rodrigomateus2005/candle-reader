import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-tool-box-button',
  templateUrl: './tool-box-button.component.html',
  styleUrls: ['./tool-box-button.component.scss']
})
export class ToolBoxButtonComponent implements OnInit {


  private _icon: string;
  public get icon(): string {
    return this._icon;
  }
  @Input()
  public set icon(v: string) {
    this._icon = v;
  }


  constructor() { }

  ngOnInit() {
  }

}
