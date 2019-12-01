using System.Threading.Tasks;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Models.DTO;
using MicroRabbit.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroRabbit.MVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITransferService _transferService;

        public IndexModel(ITransferService transferService)
        {
            _transferService = transferService;
        }


        public void OnGet()
        {

        }

        public void OnPost()
        {

        }

        public async Task Tranfer(TransferViewModel model)
        {
            var transferDTO = new TransferDTO
            {
                FromAccount = model.FromAccount,
                ToAccount = model.ToAccount,
                TransferAmount = model.TransferAmmount
            };

            await _transferService.Transfer(transferDTO);
        }
    }
}
