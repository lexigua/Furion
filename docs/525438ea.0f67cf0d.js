(window.webpackJsonp=window.webpackJsonp||[]).push([[40],{115:function(e,t,n){"use strict";n.r(t),n.d(t,"frontMatter",(function(){return l})),n.d(t,"metadata",(function(){return i})),n.d(t,"toc",(function(){return c})),n.d(t,"default",(function(){return p}));var r=n(3),a=n(7),o=(n(0),n(196)),l=(n(194),{slug:"fileupload-download",title:"3. \u6587\u4ef6\u4e0a\u4f20\u4e0b\u8f7d",author:"dotNET China",author_title:"\u4e3a\u4e2d\u56fd .NET \u5f00\u53d1\u8005\u63d0\u4f9b\u4f18\u8d28\u7684\u8d44\u8baf\u548c\u6280\u672f\u5206\u4eab\u3002",author_url:"https://www.chinadot.net",author_image_url:"https://i.loli.net/2021/01/19/M8q5a3OTZWUKicl.png",tags:["furion","furos",".net",".netcore",".net5","upload","download"]}),i={permalink:"/blog/fileupload-download",editUrl:"https://gitee.com/monksoul/Furion/tree/master/handbook/blog/2021-02-02-fileupload-download.mdx",source:"@site/blog\\2021-02-02-fileupload-download.mdx",description:"\u6587\u4ef6\u4e0b\u8f7d",date:"2021-02-02T00:00:00.000Z",tags:[{label:"furion",permalink:"/blog/tags/furion"},{label:"furos",permalink:"/blog/tags/furos"},{label:".net",permalink:"/blog/tags/net"},{label:".netcore",permalink:"/blog/tags/netcore"},{label:".net5",permalink:"/blog/tags/net-5"},{label:"upload",permalink:"/blog/tags/upload"},{label:"download",permalink:"/blog/tags/download"}],title:"3. \u6587\u4ef6\u4e0a\u4f20\u4e0b\u8f7d",readingTime:.46,truncated:!0,nextItem:{title:"2. HttpContext \u5e94\u7528",permalink:"/blog/httpcontext"}},c=[{value:"\u6587\u4ef6\u4e0b\u8f7d",id:"\u6587\u4ef6\u4e0b\u8f7d",children:[]},{value:"\u6587\u4ef6\u4e0a\u4f20",id:"\u6587\u4ef6\u4e0a\u4f20",children:[]}],u={toc:c};function p(e){var t=e.components,n=Object(a.a)(e,["components"]);return Object(o.b)("wrapper",Object(r.a)({},u,n,{components:t,mdxType:"MDXLayout"}),Object(o.b)("h2",{id:"\u6587\u4ef6\u4e0b\u8f7d"},"\u6587\u4ef6\u4e0b\u8f7d"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-cs"}),'[HttpGet, NonUnify]\npublic IActionResult FileDownload(string path, string fileName)\n{\n    string filePath = Path.GetFullPath("~/temp/").Replace("~\\\\", "") + path;\n    return new FileStreamResult(new FileStream(filePath, FileMode.Open), "application/octet-stream") { FileDownloadName = fileName };\n}\n')),Object(o.b)("h2",{id:"\u6587\u4ef6\u4e0a\u4f20"},"\u6587\u4ef6\u4e0a\u4f20"),Object(o.b)("pre",null,Object(o.b)("code",Object(r.a)({parentName:"pre"},{className:"language-cs"}),"[HttpPost, NonUnify]\npublic async Task<IActionResult> UploadFileAsync(List<IFormFile> files)\n{\n    long size = files.Sum(f => f.Length);\n\n    foreach (var formFile in files)\n    {\n        if (formFile.Length > 0)\n        {\n            var filePath = Path.GetTempFileName();  // \u53ef\u4ee5\u66ff\u4ee3\u4e3a\u4f60\u9700\u8981\u5b58\u50a8\u7684\u771f\u5b9e\u8def\u5f84\n\n            using (var stream = System.IO.File.Create(filePath))\n            {\n                await formFile.CopyToAsync(stream);\n            }\n        }\n    }\n\n    return Ok(new { count = files.Count, size });\n}\n")))}p.isMDXComponent=!0},194:function(e,t,n){"use strict";n.d(t,"b",(function(){return o})),n.d(t,"a",(function(){return l}));var r=n(21),a=n(195);function o(){const{siteConfig:{baseUrl:e="/",url:t}={}}=Object(r.default)();return{withBaseUrl:(n,r)=>function(e,t,n,{forcePrependBaseUrl:r=!1,absolute:o=!1}={}){if(!n)return n;if(n.startsWith("#"))return n;if(Object(a.b)(n))return n;if(r)return t+n;const l=n.startsWith(t)?n:t+n.replace(/^\//,"");return o?e+l:l}(t,e,n,r)}}function l(e,t={}){const{withBaseUrl:n}=o();return n(e,t)}},195:function(e,t,n){"use strict";function r(e){return!0===/^(\w*:|\/\/)/.test(e)}function a(e){return void 0!==e&&!r(e)}n.d(t,"b",(function(){return r})),n.d(t,"a",(function(){return a}))},196:function(e,t,n){"use strict";n.d(t,"a",(function(){return s})),n.d(t,"b",(function(){return b}));var r=n(0),a=n.n(r);function o(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function l(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function i(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?l(Object(n),!0).forEach((function(t){o(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):l(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function c(e,t){if(null==e)return{};var n,r,a=function(e,t){if(null==e)return{};var n,r,a={},o=Object.keys(e);for(r=0;r<o.length;r++)n=o[r],t.indexOf(n)>=0||(a[n]=e[n]);return a}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(r=0;r<o.length;r++)n=o[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(a[n]=e[n])}return a}var u=a.a.createContext({}),p=function(e){var t=a.a.useContext(u),n=t;return e&&(n="function"==typeof e?e(t):i(i({},t),e)),n},s=function(e){var t=p(e.components);return a.a.createElement(u.Provider,{value:t},e.children)},f={inlineCode:"code",wrapper:function(e){var t=e.children;return a.a.createElement(a.a.Fragment,{},t)}},d=a.a.forwardRef((function(e,t){var n=e.components,r=e.mdxType,o=e.originalType,l=e.parentName,u=c(e,["components","mdxType","originalType","parentName"]),s=p(n),d=r,b=s["".concat(l,".").concat(d)]||s[d]||f[d]||o;return n?a.a.createElement(b,i(i({ref:t},u),{},{components:n})):a.a.createElement(b,i({ref:t},u))}));function b(e,t){var n=arguments,r=t&&t.mdxType;if("string"==typeof e||r){var o=n.length,l=new Array(o);l[0]=d;var i={};for(var c in t)hasOwnProperty.call(t,c)&&(i[c]=t[c]);i.originalType=e,i.mdxType="string"==typeof e?e:r,l[1]=i;for(var u=2;u<o;u++)l[u]=n[u];return a.a.createElement.apply(null,l)}return a.a.createElement.apply(null,n)}d.displayName="MDXCreateElement"}}]);