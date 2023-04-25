# PHP CodeIgniter & Laravel

### CodeIgniter Example Code:
``` PHP
// Controller
class Welcome extends CI_Controller {

    public function index()
    {
        $data['title'] = "Welcome to CodeIgniter!";
        $data['message'] = "This is an example of CodeIgniter application.";

        $this->load->view('welcome_message', $data);
    }
}
```


### Laravel Example Code:
``` PHP
namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Controllers\Controller;

class WelcomeController extends Controller
{
    public function index()
    {
        $data = [
            'title' => 'Welcome to Laravel!',
            'message' => 'This is an example of Laravel application.'
        ];

        return view('welcome', $data);
    }
}
```

 CodeIgniter uses the `$this` object to load views and pass data to them, while Laravel uses a view() function and the array named $data or with compact() function to pass data to views. CodeIgniter also does not rely heavily on namespaces, whereas Laravel uses them extensively.

 In terms of functionality, Laravel offers more features and modules than CodeIgniter, which can make the code more complex but also provides greater flexibility and customization options. CodeIgniter, on the other hand, is designed to be lightweight and easy to use, making it a good choice for simpler projects or those that do not require extensive customization.