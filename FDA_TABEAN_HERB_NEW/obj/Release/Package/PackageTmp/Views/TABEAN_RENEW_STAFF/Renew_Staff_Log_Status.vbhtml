<div class="table-responsive">
    <table class="table table-hover table-striped"  style="font-size:12px">
        <thead>
            <tr>
                <th scope="col">ดำลับ</th>
                <th scope="col">ชื่อผู้ดำเนินการ</th>
                <th scope="col">ชื่อสถานะ</th>
                <th scope="col">วันที่ดำเนินการ</th>
            </tr>
        </thead>
        <tbody>
            <tr ng-if="Log_Status.length===0">
                <td colspan="5" class="text-center text-base-danger">--- ไม่มีรายการ---</td>
            </tr>
            <tr ng-repeat="x in Log_Status">
                <td hidden="hidden">{{x.IDA}} </td>
                <td>{{x.index}} </td>
                <td>{{x.STAFF_NAME}} </td>
                @*<td>{{x.STATUS_NAME}} </td>*@
                <td>{{x.STATUS_NAME_STAFF}} </td>
                <td>{{x.STATUS_DATE_TH}} </td>
            </tr>
        </tbody>
    </table>
</div>