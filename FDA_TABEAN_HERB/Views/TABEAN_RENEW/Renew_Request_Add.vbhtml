<form>
    <div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1000px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">
            <div style="text-align:center;">
                <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:45px; Width:90%" ng-click="BTN_ADD_REQUEST_CLICK()" value="สร้างคำขอ" />
            </div>
            <div style="height: 15px;"></div>
            <div style="text-align:center;">
                <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height: 45px; Width: 90% " data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
            </div>       
        </div>
    </div>
</form>