import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
    templateUrl: './home.component.html',
    animations: [appModuleAnimation()]
})
export class HomeComponent extends AppComponentBase implements AfterViewInit {

    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {

        $(function () {
            // Widgets count
            $('.count-to').countTo();

            // Sales count to
            $('.sales-count-to').countTo({
                formatter: function (value, options) {
                    return '$' + value.toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, ' ').replace('.', ',');
                }
            });

            initDonutChart();
            initSparkline();
            initChartLine();
        });

        let realtime = 'on';

        function initSparkline() {
            $('.sparkline').each(function () {
                const $this = $(this);
                $this.sparkline('html', $this.data());
            });
        }


        function initChartLine() {
            $('.chart.chart-line').each(function () {
                const $this = $(this);
                $this.sparkline('html', {
                    type: 'line',
                    width: '60px',
                    height: '45px',
                    lineColor: '#fff',
                    lineWidth: 1.3,
                    fillColor: 'rgba(0,0,0,0)',
                    spotColor: 'rgba(255,255,255,0.40)',
                    maxSpotColor: 'rgba(255,255,255,0.40)',
                    minSpotColor: 'rgba(255,255,255,0.40)',
                    spotRadius: 3,
                    highlightSpotColor: '#fff'
                });
            });
        }

        function initDonutChart() {
            ((window as any).Morris).Donut({
                element: 'donut_chart',
                data: [{
                    label: 'Chrome',
                    value: 37
                }, {
                    label: 'Firefox',
                    value: 30
                }, {
                    label: 'Safari',
                    value: 18
                }, {
                    label: 'Opera',
                    value: 12
                },
                {
                    label: 'Other',
                    value: 3
                }],
                colors: ['rgb(233, 30, 99)', 'rgb(0, 188, 212)', 'rgb(255, 152, 0)', 'rgb(0, 150, 136)', 'rgb(96, 125, 139)'],
                formatter: function (y) {
                    return y + '%';
                }
            });
        }

        let data = [];
        const totalPoints = 110;

        function getRandomData() {
            if (data.length > 0) { data = data.slice(1); }

            while (data.length < totalPoints) {
                const prev = data.length > 0 ? data[data.length - 1] : 50;
                let y = prev + Math.random() * 10 - 5;
                if (y < 0) { y = 0; } else if (y > 100) { y = 100; }

                data.push(y);
            }

            const res = [];
            for (let i = 0; i < data.length; ++i) {
                res.push([i, data[i]]);
            }

            return res;
        }
    }
}
