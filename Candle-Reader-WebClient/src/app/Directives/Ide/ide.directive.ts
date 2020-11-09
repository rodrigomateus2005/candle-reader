import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appIde]'
})
export class IdeDirective {

  constructor(private elementRef: ElementRef) {

  }

}
