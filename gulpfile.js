var gulp = require('gulp');
var minifyCSS = require('gulp-csso');
const imagemin = require('gulp-imagemin');
//var watch = require('gulp-watch');

/*gulp.task('html', function(){
  return gulp.src('src/html/*.html')
    .pipe(gulp.dest('build/'))
});*/

gulp.task('css', function(){
  return gulp.src('src/styles/*.css')
    .pipe(minifyCSS())
    .pipe(gulp.dest('build/css'))
});

gulp.task('favicons', function(){
  return gulp.src('src/images/favicons/*')
    .pipe(imagemin())
    .pipe(gulp.dest('build/images/favicons'))
});

gulp.task('images', function(){
  return gulp.src('src/images/*.*')
    .pipe(imagemin())
    .pipe(gulp.dest('build/images'))
});

gulp.task('default', [ 'css', 'favicons', 'images' ]);

/*gulp.task('stream', function () {
  // Endless stream mode 
  return watch('src/*', { ignoreInitial: false })
      .pipe(gulp.dest('build'));
});*/

/*gulp.task('callback', function () {
  // Callback mode, useful if any plugin in the pipeline depends on the `end`/`flush` event 
  return watch('src/*', function () {
      gulp.src('src/*')
          .pipe(gulp.dest('build'));
  });
});*/