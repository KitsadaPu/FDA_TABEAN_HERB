$(document).ready(function(){
  var map;
  var marker;
  var infobox;
  var objmarker = {};
  var tmpPopupMaker;
  var latitude = 13.721442;
  var longtitude = 100.581478;
  var address_en = "ADD NAME Addresss";
  var address_th = "ADD NAME Addresss";
  var locations = ['',latitude,longtitude];
  var zoomNum = 16;

  var _mobile={
    userAgent:navigator.userAgent.toLowerCase(),
    checkDevice:function(deviceName){
      return _mobile.userAgent.match(deviceName)==null?false:true;
    },
    iphone:function(){return _mobile.checkDevice(/iphone/);},
    ipod:function(){return _mobile.checkDevice(/ipod/);},
    ipad:function(){return _mobile.checkDevice(/ipad/);},
    android:function(){return _mobile.checkDevice(/android/);},
    blackberry:function(){return _mobile.checkDevice(/blackberry/);},
    palm:function(){return _mobile.checkDevice(/palm/);},
    symbian:function(){return _mobile.checkDevice(/symbian/);},
    ios:function(){return _mobile.iphone()||_mobile.ipod()||_mobile.ipad();},
    smartphone:function(){return _mobile.ios()||_mobile.symbian()||_mobile.blackberry()||_mobile.android();},
    smartphoneNoIpad:function(){return (_mobile.iphone()||_mobile.ipod()) ||_mobile.symbian()||_mobile.blackberry()||_mobile.android();}
  }

  var latint,longint;
    if($(window).width() < 768){
      latint = latitude
      longint = longtitude
    }else{
      latint = latitude;
      longint = longtitude;
    }

  lang = "th"

  if(lang == "en"){
    locations_name = address_en;
  }else{
    locations_name = address_th;
  }

  function handleLocationError(browserHasGeolocation, infoWindow, pos) {
      infoWindow.setPosition(pos);
      infoWindow.setContent(browserHasGeolocation ?
                            'Error: The Geolocation service failed.' :
                            'Error: Your browser doesn\'t support geolocation.');
  }
  function initialize() {
    setTimeout(function(){

      // // Create an array of styles.
      // var styles = [
      //   {
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#f5f5f5"
      //       }
      //     ]
      //   },
      //   {
      //     "elementType": "labels.icon",
      //     "stylers": [
      //       {
      //         "visibility": "off"
      //       }
      //     ]
      //   },
      //   {
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#616161"
      //       }
      //     ]
      //   },
      //   {
      //     "elementType": "labels.text.stroke",
      //     "stylers": [
      //       {
      //         "color": "#f5f5f5"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "administrative.land_parcel",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#bdbdbd"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "administrative.neighborhood",
      //     "stylers": [
      //       {
      //         "visibility": "off"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "poi",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#eeeeee"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "poi",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#757575"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "poi.park",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#e5e5e5"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "poi.park",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#9e9e9e"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "road",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#ffffff"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "road.arterial",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#757575"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "road.highway",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#dadada"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "road.highway",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#616161"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "road.local",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#9e9e9e"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "transit.line",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#e5e5e5"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "transit.station",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#eeeeee"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "water",
      //     "elementType": "geometry",
      //     "stylers": [
      //       {
      //         "color": "#c9c9c9"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "water",
      //     "elementType": "labels.text",
      //     "stylers": [
      //       {
      //         "visibility": "off"
      //       }
      //     ]
      //   },
      //   {
      //     "featureType": "water",
      //     "elementType": "labels.text.fill",
      //     "stylers": [
      //       {
      //         "color": "#9e9e9e"
      //       }
      //     ]
      //   }
      // ];
      // var styledMap = new google.maps.StyledMapType(styles,
      //   {name: "Styled Map"});

      var mapOptions = {
        zoom: zoomNum,
        scrollwheel: false,
        center: new google.maps.LatLng(latitude,longtitude),
        disableDefaultUI: true,
        mapTypeControlOptions: {
          mapTypeIds: [google.maps.MapTypeId.ROADMAP, 'map_style']
        },
        zoomControl: false,
        streetViewControl: false,
        fullscreenControl: false
      };

      map = new google.maps.Map(document.getElementById('map-area'), mapOptions);
      var icon_pin = base_url+'../images/contact/learnbig_pin1.png';
      // var left = 15;
      // if($(window).width()<768){
      //   left = 45;
      // }
      var marker = new google.maps.Marker({
        map: map,
        position: map.getCenter(),
        icon: {
          labelOrigin: new google.maps.Point(0, 0),
          url: icon_pin
        },
      });
      $("#page_contact .link-gps").click(function(){
        if (navigator.geolocation) {
          var startPos;
          var geoOptions = {
            enableHighAccuracy: true
          }
            link = "https://www.google.com/maps/dir/Current+Location/%E0%B8%AD%E0%B8%87%E0%B8%84%E0%B9%8C%E0%B8%81%E0%B8%B2%E0%B8%A3%E0%B8%A2%E0%B8%B9%E0%B9%80%E0%B8%99%E0%B8%AA%E0%B9%82%E0%B8%81/@13.721442,100.581478,15z/data=!4m2!3m1!1s0x0:0x37705f32525a8578?sa=X&ved=0ahUKEwiljMfp-dfTAhWBL48KHbLeD-4Q_BIIhQEwDQ"
            $("#page_contact .link-gps").unbind( "click" );
            $("#page_contact .link-gps").click(function(){
              window.open(link,"_blank");  
            });
            var geoSuccess = function(position) {
              startPos = position;
              // console.log(startPos.coords.longitude);
              intlat = startPos.coords.latitude;
              intlong = startPos.coords.longitude;
              // test
              // intlat = 14.093649;
              // intlong = 99.861288;

              link = "https://www.google.com/maps/dir/"+intlat+","+intlong+"/%E0%B8%AD%E0%B8%87%E0%B8%84%E0%B9%8C%E0%B8%81%E0%B8%B2%E0%B8%A3%E0%B8%A2%E0%B8%B9%E0%B9%80%E0%B8%99%E0%B8%AA%E0%B9%82%E0%B8%81/@13.721442,100.581478,15z/data=!4m2!3m1!1s0x0:0x37705f32525a8578?sa=X&ved=0ahUKEwiljMfp-dfTAhWBL48KHbLeD-4Q_BIIhQEwDQ"
              $("#page_contact .link-gps").unbind( "click" );
              $("#page_contact .link-gps").click(function(){
                window.open(link,"_blank");  
              });
            // $("#page_contact .link-gps").click();
            };
            var geoError = function(error) {
              // alert('Error occurred. Error code: ' + error.code);
              // error.code can be:
              //   0: unknown error
              //   1: permission denied
              //   2: position unavailable (error response from location provider)
              //   3: timed out
              // var infoWindow = new google.maps.InfoWindow({map: map});
              // handleLocationError(true, infoWindow, map.getCenter());
            };
            navigator.geolocation.getCurrentPosition(geoSuccess, geoError, geoOptions);
        } else {
            // Browser doesn't support Geolocation
            // var infoWindow = new google.maps.InfoWindow({map: map});
            // handleLocationError(false, infoWindow, map.getCenter());
        }
      });

      google.maps.event.addListener(marker, 'click', (function(marker) {
        return function() {
           var com_name = "add comp name";

            if(_mobile.ios()){
              window.open("http://maps.google.com/maps/place/"+com_name+"/@"+latitude+","+longtitude+",17z/data=!4m5!3m4!1s0x0:0x37705f32525a8578!8m2!3d13.721442!4d100.581478");
            }else if(_mobile.android()){
              var opentab = window.open("geo:"+latitude+","+longtitude+"?q="+latitude+","+longtitude+"("+com_name+")&z=15");

              setTimeout(function(){
                if(opentab){
                  opentab.location = "https://play.google.com/store/apps/details?id=com.google.android.apps.maps";
                }
              },1000);
            }else{
              window.open("http://maps.google.com/maps/place/"+com_name+"/@"+latitude+","+longtitude+",17z/data=!4m5!3m4!1s0x0:0x37705f32525a8578!8m2!3d13.721442!4d100.581478");
            }
          // openMakerPopup(marker);
        }
      })(marker));
      // google.maps.event.addListener(marker, 'mouseover', (function(marker) {
      //   return function() {
      //     marker.popup.open(map,marker);
      //   }
      // })(marker));
      // google.maps.event.addListener(marker, 'mouseout', (function(marker) {
      //   return function() {
      //     // if (infobox.isOpen) {
      //     //   infobox.isOpen = false;
      //     // }else{
      //     //   marker.popup.close();
      //     // }
      //   }
      // })(marker));  
      objmarker[locations[0][0]] = marker;

      google.maps.event.addDomListener(window, "resize", function() {
        var center = map.getCenter();

        google.maps.event.trigger(map, "resize");
        map.setCenter(center);

        center = new google.maps.LatLng(latint,longint);
        map.panTo(center);
      });

      // map.mapTypes.set('map_style', styledMap);
      // map.setMapTypeId('map_style');
      // var zoomControlDiv = document.createElement('div');
      // var zoomControl = new ZoomControl(zoomControlDiv, map);

      // zoomControlDiv.index = 1;
      // map.controls[google.maps.ControlPosition.TOP_RIGHT].push(zoomControlDiv);

      center = new google.maps.LatLng(latint,longint);
      map.panTo(center);
    },2000);
    $(window).resize(function(){
      if($(window).width() < 768){
        latint = latitude
        longint = longtitude
      }else{
        latint = latitude;
        longint = longtitude-0.006;
      }
      var center = map.getCenter();

      google.maps.event.trigger(map, "resize");
      map.setCenter(center);

      center = new google.maps.LatLng(latint,longint);
      map.panTo(center);
    });
  }
    google.maps.event.addDomListener(window, 'load', initialize);
  // google.maps.event.addDomListener(window, 'resize', initialize);

  // function openMakerPopup(m){
  //   if (infobox) {
  //     infobox.isOpen = true;
  //     if (tmpPopupMaker && typeof(tmpPopupMaker.close) == "function") {
  //       tmpPopupMaker.close();
  //     }
  //     m.popup.open(map,m);
  //     tmpPopupMaker = m.popup;
  //   }
  // }

  var objmap ;
  function ZoomControl(controlDiv, map) {
    
    // Creating divs & styles for custom zoom control
    controlDiv.style.padding = '15px';
    controlDiv.style.paddingRight = '35px';

    // Set CSS for the control wrapper
    var controlWrapper = document.createElement('div');
    controlWrapper.style.backgroundColor = 'transparent';

    controlWrapper.style.cursor = 'pointer';
    controlWrapper.style.textAlign = 'center';
    controlWrapper.style.width = '96px'; 
    controlWrapper.style.height = '32px';
    controlDiv.appendChild(controlWrapper);
    
    // Set CSS for the zoomIn
    var zoomInButton = document.createElement('div');
    zoomInButton.style.width = '32px'; 
    zoomInButton.style.height = '32px';
    zoomInButton.style.cssFloat = "left";
    /* Change this to be the .png image you want to use */
    zoomInButton.style.backgroundColor = 'transparent';
    zoomInButton.style.color = "#00adee";
    zoomInButton.style.fontSize = "18px";
    zoomInButton.style.lineHeight = "32px";
    zoomInButton.style.border = '1px solid #00adee';
    zoomInButton.innerHTML = "+";
    controlWrapper.appendChild(zoomInButton);
      
    // Set CSS for the zoomOut
    var zoomOutButton = document.createElement('div');
    zoomOutButton.style.width = '32px'; 
    zoomOutButton.style.height = '32px';
    zoomOutButton.style.cssFloat = "left";
    zoomOutButton.style.lineHeight = "32px";
    zoomOutButton.style.color = "#00adee";
    zoomOutButton.style.fontSize = "18px";
    zoomOutButton.style.letterSpacing = "-1px";
    zoomOutButton.innerHTML = "--";
    /* Change this to be the .png image you want to use */
    zoomOutButton.style.backgroundColor = 'transparent';
    zoomOutButton.style.border = '1px solid #00adee';
    zoomOutButton.style.borderLeft  = '0px';
    controlWrapper.appendChild(zoomOutButton);

    var fullButton = document.createElement('div');
    fullButton.style.width = '32px'; 
    fullButton.style.height = '32px';
    fullButton.style.cssFloat = "left";
    fullButton.style.lineHeight = "32px";
    fullButton.style.color = "#00adee";
    fullButton.style.fontSize = "18px";
    fullButton.style.letterSpacing = "-1px";
    /* Change this to be the .png image you want to use */
    fullButton.style.backgroundImage = "url('"+base_url+"images/contact/fullscreen.svg')";
    fullButton.style.backgroundColor = 'transparent';
    fullButton.style.backgroundPosition = 'center center';
    fullButton.style.backgroundRepeat = 'no-repeat';
    fullButton.style.border = '1px solid #00adee';
    fullButton.style.borderLeft  = '0px';
    controlWrapper.appendChild(fullButton);

      var fullScreen = false;
      var interval;
      var mapDiv = map.getDiv();
      var divStyle = mapDiv.style;
      if (mapDiv.runtimeStyle) {
          divStyle = mapDiv.runtimeStyle;
      }
      var originalPos = divStyle.position;
      var originalWidth = divStyle.width;
      var originalHeight = divStyle.height;
      // ie8 hack
      if (originalWidth === "") {
          originalWidth = mapDiv.style.width;
      }
      if (originalHeight === "") {
          originalHeight = mapDiv.style.height;
      }
      var originalTop = divStyle.top;
      var originalLeft = divStyle.left;
      var originalZIndex = divStyle.zIndex;
      var bodyStyle = document.body.style;
      if (document.body.runtimeStyle) {
          bodyStyle = document.body.runtimeStyle;
      }
      var originalOverflow = bodyStyle.overflow;
      objmap = map; 
      controlWrapper.goFullScreen = function () {
        map = objmap;
        $("#header").hide();
        $("#footer").hide();
        $("#page-contact .wrap-content").hide();
        $("#page-contact").css("margin-top","0");
          var center = map.getCenter();
          mapDiv.style.position = "fixed";
          mapDiv.style.width = "100%";
          mapDiv.style.height = "100% !important";
          mapDiv.style.top = "0";
          mapDiv.style.left = "0";
          mapDiv.style.zIndex = "9999";
          document.body.style.overflow = "hidden";

          // var bodytem = document.getElementsByID("content");
          // console.log(bodytem);
          $("#content").css({   position: "relative",'z-index': 999});
          // $(controlWrapper).find("div div").html();
          fullScreen = true;
          // google.objmap.event.trigger(objmap, "resize");
          // map.setCenter(new google.maps.LatLng(latitude,longtitude));
          var marker = new google.maps.Marker({
            position: map.getCenter()
          });
          setTimeout(function(){
            map.setCenter(marker.getPosition());
          },10);
          // this works around street view causing the map to disappear, which is caused by Google Maps setting the 
          // css position back to relative. There is no event triggered when Street View is shown hence the use of setInterval
          interval = setInterval(function () {
              if (mapDiv.style.position !== "fixed") {
                  mapDiv.style.position = "fixed";
                  google.map.event.trigger(map, "resize");
              }
          }, 100);
      };
      controlWrapper.exitFullScreen = function () {
        map = objmap;
        $("#page-contact .wrap-content").show();
        $("#page-contact").css("margin-top","auto");
        $("#header").show();
        $("#footer").show();
          var center = map.getCenter();
          if (originalPos === "") {
              mapDiv.style.position = "relative";
          }
          else {
              mapDiv.style.position = originalPos;
          }
          mapDiv.style.width = originalWidth;
          mapDiv.style.height = originalHeight;
          mapDiv.style.top = originalTop;
          mapDiv.style.left = originalLeft;
          mapDiv.style.zIndex = originalZIndex;
          $("#content").css({   position: "static",'z-index': 0});
          document.body.style.overflow = originalOverflow;
          // $(controlWrapper).find("div div").html(enterFull);
          fullScreen = false;
          google.maps.event.trigger(map, "resize");
          map.setCenter(new google.maps.LatLng(latitude,longtitude));
          clearInterval(interval);
      };

    // Setup the click event listener - zoomIn
      google.maps.event.addDomListener(zoomInButton, 'click', function() {
        if(map.getZoom() < 17){
          map.setZoom(map.getZoom() + 1);
      }
      });
      
    // Setup the click event listener - zoomOut
      google.maps.event.addDomListener(zoomOutButton, 'click', function() {
        if(map.getZoom() > 13){
          map.setZoom(map.getZoom() - 1);
        }
      });  
      google.maps.event.addDomListener(fullButton, "click", function () {
        if (!fullScreen) {
            controlWrapper.goFullScreen();
            // console.log(map);
             google.maps.event.trigger(map, "resize");
        }
        else {
            controlWrapper.exitFullScreen();
        }
    });
  }
});