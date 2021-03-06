window.blazor_methods = {
    CreateCookie: function (name, value, days) {
     var expires;
     if (days) {
        var date = new Date();
         date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
          expires = "; expires=" + date.toGMTString();
     }
      else {
         expires = "";
     }
      document.cookie = name + "=" + value + expires + "; path=/";
   },
   getCookie: (searchName) => {
      const cookies = document.cookie.split(';')
      if (cookies) {
         for(let i =0; i< cookies.length; i++) {
            let data = cookies[i].split('=')
            if (data[0] == searchName) {
               return data[1]
            }
         }
      }
      return ''
   },
   deleteAllCookies: (searchName) => {
      document.cookie = ''
   },
   createQueryString: (queryString) => {
      const params = new URLSearchParams(queryString)
      const data = {}
      for (p of params.entries()) {
         data[p[0]] = p[1]
      }
      return data
   }
}

