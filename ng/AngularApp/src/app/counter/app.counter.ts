import {Component, Input} from '@angular/core';

@Component({
  selector: 'app-counter',
  template: '<h4>Lets Count</h4>' +
  '{{num}}' +
  '<Button (click)="(Increase())">Click me to Increase!!</Button>' +
  '<Button (click)="(Decrease())">Click me to Decrease!!</Button>' +
  '<Button (click)="(Reset())">Click me to Reset!!</Button>'
})
export class CounterComponent {
  num = 0;

  Increase() {
    this.num += 1;
  }

  Decrease() {
    this.num -= 1;
  }

  Reset() {
    this.num = 0;
  }
}
