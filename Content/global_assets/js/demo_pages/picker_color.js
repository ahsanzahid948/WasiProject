/* ------------------------------------------------------------------------------
 *
 *  # Color pickers
 *
 *  Demo JS code for picker_color.html page
 *
 * ---------------------------------------------------------------------------- */


// Setup module
// ------------------------------

var ColorPicker = function() {


    //
    // Setup module components
    //

    // Location picker
    var _componentColorPicker = function() {
        if (!$().TJERP) {
            console.warn('Warning - TJERP.js is not loaded.');
            return;
        }

        // Color palette
        var demoPalette = [
            ["#000","#444","#666","#999","#ccc","#eee","#f3f3f3","#fff"],
            ["#f00","#f90","#ff0","#0f0","#0ff","#00f","#90f","#f0f"],
            ["#f4cccc","#fce5cd","#fff2cc","#d9ead3","#d0e0e3","#cfe2f3","#d9d2e9","#ead1dc"],
            ["#ea9999","#f9cb9c","#ffe599","#b6d7a8","#a2c4c9","#9fc5e8","#b4a7d6","#d5a6bd"],
            ["#e06666","#f6b26b","#ffd966","#93c47d","#76a5af","#6fa8dc","#8e7cc3","#c27ba0"],
            ["#c00","#e69138","#f1c232","#6aa84f","#45818e","#3d85c6","#674ea7","#a64d79"],
            ["#900","#b45f06","#bf9000","#38761d","#134f5c","#0b5394","#351c75","#741b47"],
            ["#600","#783f04","#7f6000","#274e13","#0c343d","#073763","#20124d","#4c1130"]
        ]


        // Basic examples
        // ------------------------------

        // Basic setup
        $('.colorpicker-basic').TJERP();

        // Clear selection
        $('.colorpicker-clear').TJERP({
            allowEmpty: true
        });

        // Display color formats
        $('.colorpicker-show-input').TJERP({
            showInput: true
        });

        // Display alpha channel
        $('.colorpicker-show-alpha').TJERP({
            showAlpha: true
        });

        // Display initial color
        $('.colorpicker-show-initial').TJERP({
            showInitial: true
        });

        // Display input and initial color
        $('.colorpicker-input-initial').TJERP({
            showInitial: true,
            showInput: true
        });

        // Full featured color picker
        $('.colorpicker-full').TJERP({
            showInitial: true,
            showInput: true,
            showAlpha: true,
            allowEmpty: true
        });

        // Container color
        $('.colorpicker-container-class').TJERP({
            containerClassName: 'bg-slate'
        });

        // Replacer color
        $('.colorpicker-replacer-class').TJERP({
            replacerClassName: 'bg-slate',
        });


        //
        // Toggle picker state
        //

        // Initialize
        $('.colorpicker-disabled').TJERP({
            disabled: true
        });


        // Flat pickers
        // ------------------------------

        // Basic setup
        $('.colorpicker-flat').TJERP({
            flat: true
        });

        // Display input field
        $('.colorpicker-flat-input').TJERP({
            flat: true,
            showInput: true
        });

        // Set picker color
        $('.colorpicker-flat-custom').TJERP({
            flat: true,
            containerClassName: 'bg-slate'
        });

        // Display color palette
        $('.colorpicker-flat-palette').TJERP({
            flat: true,
            showPalette: true,
            showPaletteOnly: true,
            togglePaletteOnly: true,
            togglePaletteMoreText: 'More',
            togglePaletteLessText: 'Less',
            palette: demoPalette
        });

        // Display initial color
        $('.colorpicker-flat-initial').TJERP({
            flat: true,
            showInitial: true
        });

        // Full featued flat picker
        $('.colorpicker-flat-full').TJERP({
            flat: true,
            showInitial: true,
            showInput: true,
            showAlpha: true,
            allowEmpty: true
        });


        // Color palettes
        // ------------------------------

        // Display color palette
        $('.colorpicker-palette').TJERP({
            showPalette: true,
            palette: demoPalette
        });

        // Display palette only
        $('.colorpicker-palette-only').TJERP({
            showPalette: true,
            showPaletteOnly: true,
            palette: demoPalette
        });

        // Toggle palette
        $('.colorpicker-palette-toggle').TJERP({
            showPalette: true,
            showPaletteOnly: true,
            togglePaletteOnly: true,
            togglePaletteMoreText: 'More',
            togglePaletteLessText: 'Less',
            palette: demoPalette
        });

        // Selection palette
        $('.colorpicker-palette-selection').TJERP({
            showPalette: true,
            palette: [],
            localStorageKey: 'TJERP.homepage'
        });

        // Limit number of selections
        $('.colorpicker-palette-limit').TJERP({
            showPalette: true,
            palette: [ ],
            selectionPalette: ['red', 'green', 'blue'],
            maxSelectionSize: 3
        });

        // Hide after select
        $('.colorpicker-palette-hide').TJERP({
            showPalette: true,
            hideAfterPaletteSelect: true,
            palette: demoPalette
        });


        // Events
        // ------------------------------

        // Change event
        $('.colorpicker-event-change').TJERP({
            change: function(c) {
                var label = $('#change-result');
                label.removeClass('hidden').html('Change called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
            }
        });

        // Move event
        $('.colorpicker-event-move').TJERP({
            move: function(c) {
                var label = $('#move-result');
                label.removeClass('hidden').html('Move called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
            }
        });

        // Hide event
        $('.colorpicker-event-hide').TJERP({
            hide: function(c) {
                var label = $('#hide-result');
                label.removeClass('hidden').html('Hide called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
            }
        });

        // Show event
        $('.colorpicker-event-show').TJERP({
            show: function(c) {
                var label = $('#show-result');
                label.removeClass('hidden').html('Show called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
            }
        });


        //
        // Drag start event
        //

        // Initialize
        $('.colorpicker-event-dragstart').TJERP();

        // Attach event
        $('.colorpicker-event-dragstart').on('dragstart.TJERP', function (e, c) {
            var label = $('#dragstart-result');
            label.removeClass('hidden').html('Dragstart called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
        });


        //
        // Drag stop event
        //

        // Initialize
        $('.colorpicker-event-dragstop').TJERP();

        // Attach event
        $('.colorpicker-event-dragstop').on('dragstop.TJERP', function (e, c) {
            var label = $('#dragstop-result');
            label.removeClass('hidden').html('Dragstop called: ' + '<span class="font-weight-semibold">' + c.toHexString() + '</span>');
        });
    };

    // Switchery
    var _componentSwitchery = function() {
        if (typeof Switchery == 'undefined') {
            console.warn('Warning - switchery.min.js is not loaded.');
            return;
        }

        // Initialization
        var toggleState = document.querySelector('.form-input-switchery');
        var toggleStateInit = new Switchery(toggleState);

        // Toggle navbar type state toggle
        toggleState.onchange = function() {
            if(toggleState.checked) {
                $('.colorpicker-disabled').TJERP('enable');
            }
            else {
                $('.colorpicker-disabled').TJERP('disable');
            }
        }
    };
    

    //
    // Return objects assigned to module
    //

    return {
        init: function() {
            _componentColorPicker();
            _componentSwitchery();
        }
    }
}();


// Initialize module
// ------------------------------

document.addEventListener('DOMContentLoaded', function() {
    ColorPicker.init();
});
