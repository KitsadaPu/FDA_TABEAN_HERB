var outlineImage = new Image();
var drawingAreaX = 0;
var drawingAreaY = 0;
var drawingAreaWidth = 390;
var drawingAreaHeight = 380;
var eraserBackgroundImage = new Image();
var totalLoadResources = 8;
var curLoadResNum = 0;


//var outlineImageHPT = new Image();
//var drawingAreaXHPT = 0;
//var drawingAreaYHPT = 0;
//var drawingAreaWidthHPT = 390;
//var drawingAreaHeightHPT = 380;
//var eraserBackgroundImageHPT = new Image();
//var totalLoadResourcesHPT = 8;
//var curLoadResNumHPT = 0;
//$(document).ready(function () {
    //prepareCanvas(); 
    //$('#filegetphoto').change(function (e) {
    //    readURL(this);
    //});
    //document.getElementById('download').addEventListener('click', download, false);        
//});

//function readURL(input) {    //  เลือกไฟล์ ใน file input แล้ว รูปจะ show ใน กรอป
//    if (input.files && input.files[0]) {
//        var reader = new FileReader();

//        reader.onload = function (e) {
//            $('#canvasDiv').attr('src', e.target.result);
//        }
//        reader.readAsDataURL(input.files[0]);
//    }
//}

function prepareCanvas(){
    var canvasDiv = document.getElementById('canvasDiv');
    canvas = document.createElement('canvas');        
    canvas.width = 390;
    canvas.height = 380;        
    canvas.setAttribute('id', 'canvas');
    if (canvasDiv != null) {
        canvasDiv.appendChild(canvas);
    }
    $("#canvas").css({
        "border-color": "#000000",
        "border-width": "1px",
        "border-style": "solid"
    });
    if (typeof G_vmlCanvasManager != 'undefined') {
        canvas = G_vmlCanvasManager.initElement(canvas);
    }
    context = canvas.getContext("2d");
        
    $('#filegetphoto').change(function (e) {

        outlineImage.onload = function () {
            //resourceLoaded();
            context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
        };
        //outlineImage.src = "/Image/BottonLeftHand.gif";
                
        if (this.files && this.files[0]) {
            var reader = new FileReader();
                
            reader.onload = function (e) {
                //$('#canvas').attr('src', e.target.result);
                outlineImage.src = e.target.result;
            }
            reader.readAsDataURL(this.files[0]);                
        }
    });     

    $('#canvas').mousedown(function (e) {
        var mouseX = e.pageX - this.offsetLeft;
        var mouseY = e.pageY - this.offsetTop;

        paint = true;
        addClick(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
        redraw();
    });

    $('#canvas').mousemove(function (e) {
        if (paint) {
            addClick(e.pageX - this.offsetLeft, e.pageY - this.offsetTop, true);
            redraw();
        }
    });

    $('#canvas').mouseup(function (e) {
        paint = false;
    });

    $('#canvas').mouseleave(function (e) {
        paint = false;
    });
    //-------------------------------สี---------------------------------------
    var colorRed = "#FF0000";
    var colorBlue = "#0000FF";
    var colorBlack = "#000000";
    var colorYellow = "#FFFF00";

    var curColor = colorBlack;

    $('#ddlcolor').change(function (e) {
        var val = $('#ddlcolor option:selected').text()
        if (val == "" || val == "black") {
            curColor = colorBlack;
        }
        else if (val == "red") {
            curColor = colorRed;
        }
        else if (val == "blue") {
            curColor = colorBlue;
        }
        else if (val == "yellow") {
            curColor = colorYellow;
        }
    });

    //$('#btnRed').click(function (e){
    //    curColor = colorRed;
    //});
    //$('#btnBlue').click(function (e) {
    //    curColor = colorBlue;
    //});
    //$('#btnBlack').click(function (e) {
    //    curColor = colorBlack;
    //});
    //$('#btnYellow').click(function (e) {
    //    curColor = colorYellow;
    //});

    var clickColor = new Array();
    //-------------------------------สี---------------------------------------
    //-------------------------------ขนาด-------------------------------------
    var borderS = 2;
    var borderM = 5;
    var borderL = 10;
    var borderXL = 15;
    var curSize = borderM;

    $('#ddlsize').change(function (e) {
        var val = $('#ddlsize option:selected').text()
        if (val == "" || val == "m")
        {
            curSize = borderM;
        }
        else if(val == "s")
        {
            curSize = borderS;
        }
        else if (val == "l") {
            curSize = borderL;
        }
        else if (val == "xl") {
            curSize = borderXL;
        }
    });

    //$('#btnSizeS').click(function (e) {
    //    curSize = borderS;
    //});
    //$('#btnSizeM').click(function (e) {
    //    curSize = borderM;
    //});
    //$('#btnSizeL').click(function (e) {
    //    curSize = borderL;
    //});
    //$('#btnSizeXL').click(function (e) {
    //    curSize = borderXL;
    //});

    var clickSize = new Array();
    //-------------------------------ขนาด-------------------------------------

    var curTool = "";
    $('#btnEraser').click(function (e) {
        curTool = "eraser";
    });
    $('#btnMarker').click(function (e) {
        curTool = "marker";
    });        

    var clickTool = new Array();        

    var clickX = new Array();
    var clickY = new Array();
    var clickDrag = new Array();
    var paint;

    function addClick(x, y, dragging) {
        clickX.push(x);
        clickY.push(y);
        clickTool.push(curTool);
        clickDrag.push(dragging);
        //if (curTool == "eraser") {
        //    clickColor.push("white");
        //} else {
        //    clickColor.push(curColor);
        //}
        clickColor.push(curColor);
        clickSize.push(curSize);
    }

    function redraw() {
        //context.clearRect(0, 0, context.canvas.width, context.canvas.height); // Clears the canvas
            
        //context.strokeStyle = "#df4b26";
        context.lineJoin = "round";
        //context.lineWidth = 5;

        for (var i = 0; i < clickX.length; i++) {
            context.beginPath();
            if (clickDrag[i] && i) {
                context.moveTo(clickX[i - 1], clickY[i - 1]);
            } else {
                context.moveTo(clickX[i] - 1, clickY[i]);
            }
            context.lineTo(clickX[i], clickY[i]);
            context.closePath();
            if (clickTool[i] == "eraser") {
                //context.globalCompositeOperation = "destination-out"; // To erase instead of draw over with white
                context.strokeStyle = 'white';                    
            } else {
                //context.globalCompositeOperation = "source-over";	// To erase instead of draw over with white
                context.strokeStyle = clickColor[i];
            }
            //context.strokeStyle = clickColor[i];
            context.lineWidth = clickSize[i];
            context.stroke();
        }
        context.globalAlpha = 1;
        //if (curTool == "eraser") {
        //    context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
        //}
    }
    //context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
}

//function prepareCanvasHPT() {
//    var canvasDiv = document.getElementById('canvasDivHPT');
//    canvas = document.createElement('canvas');
//    canvas.width = 390;
//    canvas.height = 380;
//    canvas.setAttribute('id', 'canvasHPT');
//    if (canvasDiv != null) {
//        canvasDiv.appendChild(canvas);
//    }
//    $("#canvasHPT").css({
//        "border-color": "#000000",
//        "border-width": "1px",
//        "border-style": "solid"
//    });
//    if (typeof G_vmlCanvasManager != 'undefined') {
//        canvas = G_vmlCanvasManager.initElement(canvas);
//    }
//    context = canvas.getContext("2d");

//    $('#filegetphotoHPT').change(function (e) {

//        outlineImageHPT.onload = function () {
//            //resourceLoaded();
//            context.drawImage(outlineImageHPT, drawingAreaXHPT, drawingAreaYHPT, drawingAreaWidthHPT, drawingAreaHeightHPT);
//        };
//        //outlineImage.src = "/Image/BottonLeftHand.gif";

//        if (this.files && this.files[0]) {
//            var reader = new FileReader();

//            reader.onload = function (e) {
//                //$('#canvas').attr('src', e.target.result);
//                outlineImageHPT.src = e.target.result;
//            }
//            reader.readAsDataURL(this.files[0]);
//        }
//    });

//    $('#canvasHPT').mousedown(function (e) {
//        var mouseX = e.pageX - this.offsetLeft;
//        var mouseY = e.pageY - this.offsetTop;

//        paint = true;
//        addClickHPT(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
//        redrawHPT();
//    });

//    $('#canvasHPT').mousemove(function (e) {
//        if (paint) {
//            addClickHPT(e.pageX - this.offsetLeft, e.pageY - this.offsetTop, true);
//            redrawHPT();
//        }
//    });

//    $('#canvasHPT').mouseup(function (e) {
//        paint = false;
//    });

//    $('#canvasHPT').mouseleave(function (e) {
//        paint = false;
//    });
//    //-------------------------------สี---------------------------------------
//    var colorRed = "#FF0000";
//    var colorBlue = "#0000FF";
//    var colorBlack = "#000000";
//    var colorYellow = "#FFFF00";

//    var curColor = colorBlack;

//    $('#ddlcolorHPT').change(function (e) {
//        var val = $('#ddlcolorHPT').val()
//        if (val == "" || val == "black") {
//            curColor = colorBlack;
//        }
//        else if (val == "red") {
//            curColor = colorRed;
//        }
//        else if (val == "blue") {
//            curColor = colorBlue;
//        }
//        else if (val == "yellow") {
//            curColor = colorYellow;
//        }
//    });

//    //$('#btnRed').click(function (e){
//    //    curColor = colorRed;
//    //});
//    //$('#btnBlue').click(function (e) {
//    //    curColor = colorBlue;
//    //});
//    //$('#btnBlack').click(function (e) {
//    //    curColor = colorBlack;
//    //});
//    //$('#btnYellow').click(function (e) {
//    //    curColor = colorYellow;
//    //});

//    var clickColor = new Array();
//    //-------------------------------สี---------------------------------------
//    //-------------------------------ขนาด-------------------------------------
//    var borderS = 2;
//    var borderM = 5;
//    var borderL = 10;
//    var borderXL = 15;
//    var curSize = borderM;

//    $('#ddlsizeHPT').change(function (e) {
//        var val = $('#ddlsizeHPT').val()
//        if (val == "" || val == "m") {
//            curSize = borderM;
//        }
//        else if (val == "s") {
//            curSize = borderS;
//        }
//        else if (val == "l") {
//            curSize = borderL;
//        }
//        else if (val == "xl") {
//            curSize = borderXL;
//        }
//    });

//    //$('#btnSizeS').click(function (e) {
//    //    curSize = borderS;
//    //});
//    //$('#btnSizeM').click(function (e) {
//    //    curSize = borderM;
//    //});
//    //$('#btnSizeL').click(function (e) {
//    //    curSize = borderL;
//    //});
//    //$('#btnSizeXL').click(function (e) {
//    //    curSize = borderXL;
//    //});

//    var clickSize = new Array();
//    //-------------------------------ขนาด-------------------------------------

//    var curTool = "";
//    $('#btnEraserHPT').click(function (e) {
//        curTool = "eraser";
//    });
//    $('#btnMarkerHPT').click(function (e) {
//        curTool = "marker";
//    });

//    var clickTool = new Array();

//    var clickX = new Array();
//    var clickY = new Array();
//    var clickDrag = new Array();
//    var paint;

//    function addClickHPT(x, y, dragging) {
//        clickX.push(x);
//        clickY.push(y);
//        clickTool.push(curTool);
//        clickDrag.push(dragging);
//        //if (curTool == "eraser") {
//        //    clickColor.push("white");
//        //} else {
//        //    clickColor.push(curColor);
//        //}
//        clickColor.push(curColor);
//        clickSize.push(curSize);
//    }

//    function redrawHPT() {
//        //context.clearRect(0, 0, context.canvas.width, context.canvas.height); // Clears the canvas

//        //context.strokeStyle = "#df4b26";
//        context.lineJoin = "round";
//        //context.lineWidth = 5;

//        for (var i = 0; i < clickX.length; i++) {
//            context.beginPath();
//            if (clickDrag[i] && i) {
//                context.moveTo(clickX[i - 1], clickY[i - 1]);
//            } else {
//                context.moveTo(clickX[i] - 1, clickY[i]);
//            }
//            context.lineTo(clickX[i], clickY[i]);
//            context.closePath();
//            if (clickTool[i] == "eraser") {
//                //context.globalCompositeOperation = "destination-out"; // To erase instead of draw over with white
//                context.strokeStyle = 'white';
//            } else {
//                //context.globalCompositeOperation = "source-over";	// To erase instead of draw over with white
//                context.strokeStyle = clickColor[i];
//            }
//            //context.strokeStyle = clickColor[i];
//            context.lineWidth = clickSize[i];
//            context.stroke();
//        }
//        context.globalAlpha = 1;
//        //if (curTool == "eraser") {
//        //    context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
//        //}
//    }
//    //context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
//}

//function clearCanvasHPT() {
//    var cv = document.getElementById('canvasHPT');
//    var context = cv.getContext("2d");
//    context.clearRect(0, 0, context.canvas.width, context.canvas.height);

//    $("#canvasHPT").remove();

//    prepareCanvasHPT();
//}
//function callIMGHPT(path) {
//    outlineImageHPT.onload = function () {
//        //resourceLoaded();
//        context.drawImage(outlineImageHPT, drawingAreaXHPT, drawingAreaYHPT, drawingAreaWidthHPT, drawingAreaHeightHPT);
//    };
//    outlineImageHPT.src = path;
//}
function clearCanvas()
{
    var cv = document.getElementById('canvas');
    var context = cv.getContext("2d");
    context.clearRect(0, 0, context.canvas.width, context.canvas.height);

    $("#canvas").remove();

    prepareCanvas();
}
function callIMG(path) {
    outlineImage.onload = function () {
        //resourceLoaded();
        context.drawImage(outlineImage, drawingAreaX, drawingAreaY, drawingAreaWidth, drawingAreaHeight);
    };
    path = "../" + path;
    outlineImage.src = path;    
}

//function download() {
//    var dt = canvas.toDataURL();
//    //var cv = document.getElementById("canvas");    
//    this.href = dt; //this may not work in the future..
//}
