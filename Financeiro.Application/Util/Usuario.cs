using Microsoft.AspNetCore.Http;

namespace Financeiro.Application.Util
{
    public class Usuario : IUsuario
    {
        private readonly IHttpContextAccessor _accessor;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessor"></param>

        public Usuario(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Email => _accessor.HttpContext.User.Identity.Name;
    
        public string Device => _accessor.HttpContext.Request.Headers["User-Agent"].ToString();
    }
}
