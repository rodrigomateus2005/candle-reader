import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ToolBoxButtonComponent } from './tool-box-button.component';

describe('ToolBoxButtonComponent', () => {
  let component: ToolBoxButtonComponent;
  let fixture: ComponentFixture<ToolBoxButtonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ToolBoxButtonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ToolBoxButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
