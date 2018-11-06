$(document).ready(function () {
    $("#AboutTabs").tabs();
    $("#HeadquartersAccordion").accordion();

    var othersLinks = ["https://www.youtube.com/", "https://www.linkedin.com/", "https://www.quora.com/", "https://www.pinterest.com", "https://www.snapchat.com/"];
    $("#OthersSelectable").selectable({
        selected: function () {
            $(".ui-selected", this).each(function () {
                var index = $("#OthersSelectable li").index(this);
                var url = othersLinks[index];
                window.open(url, '_blank');
            });
        }
    });

    $(".UIButton").button();
    var spinner = $("#spinner").spinner();
    var val = 0;

    function getRandomColor() {
        var letters = '0123456789ABCDEF';
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }

    $("#createBoxesButton").click(function () {
        document.getElementById("snakeDiv").innerHTML = "";
        val = spinner.spinner("value");
        for (var i = 0; i < val; i++) {
            var box = "<div class = 'snakeBox' id = 'box" + i + "'></div>";
            $("#snakeDiv").append(box);
            $("#box" + i).css("background-color", getRandomColor());
        }
    })

    function moving() {
        var duration = 1000;
        for (var i = 0; i < val; i++) {
            var boxID = "#box" + i;
            $(boxID).animate({ left: '900px' }, duration);
            $(boxID).animate({ left: '0px' }, duration);
            duration += (i + 1) * 10;
        }
        moving();
    }

    $("#createSnakeButton").click(function () {
        moving();
    });

    $("#setValuesTo300").click(function () {
        spinner.spinner("value", 300);
    })
});



