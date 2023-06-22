<nav class="navbar-default navbar-static-side" role="navigation">
    <div class="sidebar-collapse">
        <ul class="nav metismenu" id="side-menu">
            <li class="nav-header">
                <div class="dropdown profile-element">
                    <div style="text-align:center">  <img alt="image" class="rounded-circle" src="../html5/img/logo@2x.png" style="width:30%;height:30%;" /></div>

                    <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                        <span class="block m-t-xs font-bold" style="text-align:center">{{FULL_MODEL.CLS_SESSION.NameTH_Prefix}} {{FULL_MODEL.CLS_SESSION.NameTH_FirstName}} {{FULL_MODEL.CLS_SESSION.NameTH_SurName}}</span>
                            @*<span class="text-muted text-xs block" style="text-align:center">{{FULL_MODEL.PERSON_IDEM.MANAGEMENT_POSITION}}</span>*@
                    </a>
                    <ul class="dropdown-menu animated fadeInRight m-t-xs"></ul>
                </div>
                <div class="logo-element">
                    FDA
                </div>
            </li>

            <li ng-repeat="datas in GET_LEFT_MAIN" ng-class="{'active': datas.PAGE_NAME  == active_menu}">
                <a ng-if="datas.PAGE_ID != 1" href="#" ng-click="BTN_SUB_MENU_CLICK(datas.PAGE_PATH, '', $index+1,datas.PROCESS_ID,datas.MAIN_PATH, datas)"><span class="nav-label">{{datas.PAGE_NAME}}</span></a>
                <a ng-if="datas.PAGE_ID == 1" href="#" ng-click="BTN_MENU_CLICK('', 'active', $index+1,datas.PROCESS_ID,datas.MAIN_PATH, datas)">
                    @*<i class="fa fa-bar-chart-o"></i>*@ <span class="nav-label">{{datas.PAGE_NAME}}</span>
                    @*<span class="fa arrow"></span>*@
                </a>
                <ul ng-repeat="datasSub in SET_SUB_PAGE_MAIN | filter:{FK_PAGE_MAIN:MENU_ID}" ng-if="datasSub.FK_PAGE_MAIN == datas.IDA" ng-class="{'nav nav-second-level collapse in': datasSub.FK_PAGE_MAIN  == MENU_ID}">
                    <li>
                        <a href="#" ng-click="BTN_SUB_MENU_CLICK(datasSub.PAGE_PATH, 'active', $index+1,datasSub.PROCESS_ID,datasSub.MAIN_PATH, datasSub)" aria-expanded="true">{{datasSub.PAGE_NAME}}</a>
                    </li>
                </ul>
            </li>

        </ul>

    </div>
</nav>
