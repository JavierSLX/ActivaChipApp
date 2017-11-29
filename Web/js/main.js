$(function(){
	var SliderModule = (function() {
		var pb = {};
		pb.el = $('#slider');
		pb.items = {
			panel: pb.el.find('li')
		}

		// variables necesarias
		var SliderInterval,
			currentSlider = 0,
			nextSlider = 1,
			lengthSlider = pb.items.panel.length;

		// initialize
		pb.init = function(settings){
			this.settings = settings || {duration: 8000}
			var output = '';
			// activamos nuestro slider
			SliderInit();

			for(var i = 0; i < lengthSlider; i++) {
				if (i == 0) {
					output += '<li class="active"></li>';
				} else {
					output += '<li></li>';
				}
			}

			// controle del slider
			$('#slider-controls').html(output).on('click', 'li', function(e){
				var $this = $(this);
				if (currentSlider !== $this.index()) {
					changePanel($this.index());
				}
			});
		}

		var SliderInit = function() {
			SliderInterval = setInterval(pb.startSlider, pb.settings.duration);
		}

		pb.startSlider = function() {
			var panels = pb.items.panel,
				controls = $('#slider-controls li');

			if (nextSlider >= lengthSlider) {
				nextSlider = 0;
				currentSlider = lengthSlider-1;
			}

			// efectos
			controls.removeClass('active').eq(currentSlider).addClass('active');
			panels.eq(currentSlider).fadeOut('slow');
			panels.eq(nextSlider).fadeIn('slow');

			//actualizamos nuestros datos
			currentSlider = nextSlider;
			nextSlider += 1;
		}

		// funcion para controles del slider
		var changePanel = function(id) {
			clearInterval(SliderInterval);
			var panels = pb.items.panel,
				controls = $('#slider-controls li');
			// Comprobamos el ID
			if (id >= lengthSlider) {
				id = 0;
			} else if (id < 0) {
				id = lengthSlider-1;
			}

			// efectos
			controls.removeClass('active').eq(id).addClass('active');
			panels.eq(currentSlider).fadeOut('slow');
			panels.eq(id).fadeIn('slow');
			// actualizamos en nuestros datos
			currentSlider = id;
			nextSlider = id+1;

			// reactivamos slider
			SliderInit();
		}

		return pb;
	}());
	SliderModule.init({duration: 1000});
});