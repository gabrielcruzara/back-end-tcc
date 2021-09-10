(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["pages-categorias-categorias-module"],{

/***/ "+8X5":
/*!***************************************************************!*\
  !*** ./src/app/pages/categorias/categorias-routing.module.ts ***!
  \***************************************************************/
/*! exports provided: CategoriasRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CategoriasRoutingModule", function() { return CategoriasRoutingModule; });
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/router */ "tyNb");
/* harmony import */ var _categorias_lista_categorias_lista_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./categorias-lista/categorias-lista.component */ "JhSM");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "fXoL");




const routes = [
    { path: '', component: _categorias_lista_categorias_lista_component__WEBPACK_IMPORTED_MODULE_1__["CategoriasListaComponent"] },
];
class CategoriasRoutingModule {
}
CategoriasRoutingModule.ɵfac = function CategoriasRoutingModule_Factory(t) { return new (t || CategoriasRoutingModule)(); };
CategoriasRoutingModule.ɵmod = _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineNgModule"]({ type: CategoriasRoutingModule });
CategoriasRoutingModule.ɵinj = _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineInjector"]({ imports: [[_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"].forChild(routes)], _angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵsetNgModuleScope"](CategoriasRoutingModule, { imports: [_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]], exports: [_angular_router__WEBPACK_IMPORTED_MODULE_0__["RouterModule"]] }); })();


/***/ }),

/***/ "JhSM":
/*!*********************************************************************************!*\
  !*** ./src/app/pages/categorias/categorias-lista/categorias-lista.component.ts ***!
  \*********************************************************************************/
/*! exports provided: CategoriasListaComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CategoriasListaComponent", function() { return CategoriasListaComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "tyNb");


class CategoriasListaComponent {
    constructor() { }
    ngOnInit() {
    }
}
CategoriasListaComponent.ɵfac = function CategoriasListaComponent_Factory(t) { return new (t || CategoriasListaComponent)(); };
CategoriasListaComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: CategoriasListaComponent, selectors: [["app-categorias-lista"]], decls: 8, vars: 0, consts: [[1, "breadcrumb"], [1, "breadcrumb-item"], ["routerLink", "/"], [1, "breadcrumb-item-active"]], template: function CategoriasListaComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "nav");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "ol", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "li", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "a", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Inicio");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "li", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "a");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](7, "Categorias");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, directives: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterLinkWithHref"]], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJjYXRlZ29yaWFzLWxpc3RhLmNvbXBvbmVudC5jc3MifQ== */"] });


/***/ }),

/***/ "U7pz":
/*!*******************************************************************************!*\
  !*** ./src/app/pages/categorias/categorias-form/categorias-form.component.ts ***!
  \*******************************************************************************/
/*! exports provided: CategoriasFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CategoriasFormComponent", function() { return CategoriasFormComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "fXoL");

class CategoriasFormComponent {
    constructor() { }
    ngOnInit() {
    }
}
CategoriasFormComponent.ɵfac = function CategoriasFormComponent_Factory(t) { return new (t || CategoriasFormComponent)(); };
CategoriasFormComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: CategoriasFormComponent, selectors: [["app-categorias-form"]], decls: 2, vars: 0, template: function CategoriasFormComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "categorias-form works!");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJjYXRlZ29yaWFzLWZvcm0uY29tcG9uZW50LmNzcyJ9 */"] });


/***/ }),

/***/ "mlnY":
/*!*******************************************************!*\
  !*** ./src/app/pages/categorias/categorias.module.ts ***!
  \*******************************************************/
/*! exports provided: CategoriasModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CategoriasModule", function() { return CategoriasModule; });
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/common */ "ofXK");
/* harmony import */ var _categorias_routing_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./categorias-routing.module */ "+8X5");
/* harmony import */ var _categorias_lista_categorias_lista_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./categorias-lista/categorias-lista.component */ "JhSM");
/* harmony import */ var _categorias_form_categorias_form_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./categorias-form/categorias-form.component */ "U7pz");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "fXoL");





class CategoriasModule {
}
CategoriasModule.ɵfac = function CategoriasModule_Factory(t) { return new (t || CategoriasModule)(); };
CategoriasModule.ɵmod = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineNgModule"]({ type: CategoriasModule });
CategoriasModule.ɵinj = _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjector"]({ imports: [[
            _angular_common__WEBPACK_IMPORTED_MODULE_0__["CommonModule"],
            _categorias_routing_module__WEBPACK_IMPORTED_MODULE_1__["CategoriasRoutingModule"]
        ]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵsetNgModuleScope"](CategoriasModule, { declarations: [_categorias_lista_categorias_lista_component__WEBPACK_IMPORTED_MODULE_2__["CategoriasListaComponent"],
        _categorias_form_categorias_form_component__WEBPACK_IMPORTED_MODULE_3__["CategoriasFormComponent"]], imports: [_angular_common__WEBPACK_IMPORTED_MODULE_0__["CommonModule"],
        _categorias_routing_module__WEBPACK_IMPORTED_MODULE_1__["CategoriasRoutingModule"]] }); })();


/***/ })

}]);
//# sourceMappingURL=pages-categorias-categorias-module.js.map