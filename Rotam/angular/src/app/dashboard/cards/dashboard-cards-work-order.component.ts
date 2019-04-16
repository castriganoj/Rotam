import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'dashboard-cards-work-order'

})

export class DashboardCardsWorkOrderComponent extends AppComponentBase  {

    constructor(
        injector: Injector    
    ) 
    {
        super(injector);
    }
}



