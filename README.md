Dolathanchuong
                                         /T /I
                              / |/ | .-~/
                          T\ Y  I  |/  /  _
         /T               | \I  |  I  Y.-~/
        I l   /I       T\ |  |  l  |  T  /
     T\ |  \ Y l  /T   | \I  l   \ `  l Y
 __  | \l   \l  \I l __l  l   \   `  _. |
 \ ~-l  `\   `\  \  \\ ~\  \   `. .-~   |
  \   ~-. "-.  `  \  ^._ ^. "-.  /  \   |
.--~-._  ~-  `  _  ~-_.-"-." ._ /._ ." ./
 >--.  ~-.   ._  ~>-"    "\\   7   7   ]
^.___~"--._    ~-{  .-~ .  `\ Y . /    |
 <__ ~"-.  ~       /_/   \   \I  Y   : |
   ^-.__           ~(_/   \   >._:   | l______
       ^--.,___.-~"  /_/   !  `-.~"--l_ /     ~"-.
              (_/ .  ~(   /'     "~"--,Y   -=b-. _)
               (_/ .  \  :           / l      c"~o \
                \ /    `.    .     .^   \_.-~"~--.  )
                 (_/ .   `  /     /       !       )/
                  / / _.   '.   .':      /        '
                  ~(_/ .   /    _  `  .-<_
                    /_/ . ' .-~" `.  / \  \          ,z=.
                    ~( /   '  :   | K   "-.~-.______//
                      "-,.    l   I/ \_    __{--->._(==.
                       //(     \  <    ~"~"     //
                      /' /\     \  \     ,v=.  ((
                    .^. / /\     "  }__ //===-  `
                   / / ' '  "-.,__ {---(==-
                 .^ '       :  T  ~"   ll
                / .  .  . : | :!        \\
               (_/  /   | | j-"          ~^
                 ~-<_(_.^-~"
3Dola
- Get a Product List 
    - query{
        productList{
            id
            productName
            productDescription
            productPrice
            productStock
        }
    }
- Add Product Detail
    - mutation($productDetails:ProductDetailsInput!){
        addProduct(productDetails: $productDetails)  
        }
    - Parameter Input:
        {
            "productDetails": 
            {
                "id": "88888888-4444-4444-4444-999999999999",
                "productName": "Mobile36999",
                "productDescription": "Description Mobile36999",
                "productPrice": 369369,
                "productStock": 99
                }
        }
    - ![Alt text](./Images/image.png)
- Update Product Detail
    - mutation($productDetails:ProductDetailsInput!){
        updateProduct(productDetails: $productDetails)  
        }
    - Parameter Input:
        {
        "productDetails": {
            "id": "5933dc1e-03ef-457b-be6e-35a3d5ef23c4",
            "productName": "Mobile36999",
            "productDescription": "Description Mobile36999",
            "productPrice": 369369,
            "productStock": 99
            }
        }
- Delete Product Detail
    - mutation($productId:UUID!){
            deleteProduct(productId: $productId)  
        }
    - Parameter Input:
        {
            "productId": "5933dc1e-03ef-457b-be6e-35a3d5ef23c4"
        }
- Get Product Detail by Id
    - {
        productDetailsById(productId: "478b4df0-e8ed-415f-a8e3-2ba84c31ec2b") 
        {
            id
            productName
            productDescription
            productPrice
            productStock
        }
    }
