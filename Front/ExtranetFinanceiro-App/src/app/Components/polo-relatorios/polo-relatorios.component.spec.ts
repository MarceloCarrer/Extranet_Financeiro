import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PoloRelatoriosComponent } from './polo-relatorios.component';

describe('PoloRelatoriosComponent', () => {
  let component: PoloRelatoriosComponent;
  let fixture: ComponentFixture<PoloRelatoriosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PoloRelatoriosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PoloRelatoriosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
