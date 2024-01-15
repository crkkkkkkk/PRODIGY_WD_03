
body {
    background-image: url('https://th.bing.com/th/id/OIP.K7-k7-isNNjsJqOkoIx7GAAAAA?rs=1&pid=ImgDetMain');
    background-size: cover;
    height: 100vh;
}

h1 {
    color: #004D1A;
    margin-bottom: -5px;
    margin-top: 50px;
    font-size: 50px;
}

p {
    margin-bottom: -10px;
    font-size: 30px;
}

.ui {
    display: flex;
    flex-direction: column;
    align-items: center;
}

.row {
    display: flex;
}

.cell {
    border: none;
    width: 80px;
    height: 80px;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 24px;
    text-align: center;
    cursor: pointer;
}

.cell:active {
    outline: none;
}

/* 3*3 Grid */
#b1 {
    border-bottom: 1px solid gray;
    border-right: 1px solid gray;
    color: #001A1A;
}

#b2 {
    border-bottom: 1px solid gray;
    border-right: 1px solid gray;
    border-left: 1px solid gray;
    color: #001A1A;
}

#b3 {
    border-bottom: 1px solid gray;
    border-left: 1px solid gray;
    color: #001A1A;
}

#b4 {
    border-top: 1px solid gray;
    border-bottom: 1px solid gray;
    border-right: 1px solid gray;
    color: #001A1A;
}

#b5 {
    border: 1px solid gray;
    color: #001A1A;
}

#b6 {
    border-top: 1px solid gray;
    border-bottom: 1px solid gray;
    border-left: 1px solid gray;
    color: #001A1A;
}

#b7 {
    border-top: 1px solid gray;
    border-right: 1px solid gray;
    color: #001A1A;
}

#b8 {
    border-top: 1px solid gray;
    border-right: 1px solid gray;
    border-left: 1px solid gray;
    color: #001A1A;
}

#b9 {
    border-top: 1px solid gray;
    border-left: 1px solid gray;
    color: #001A1A;
}

#but {
    box-sizing: border-box;
    width: 95px;
    height: 40px;
    border: 1px solid dodgerblue;
    margin-left: auto;
    border-radius: 8px;
    font-family: Verdana;

    background-color: rgb(54, 52, 52);
    color: dodgerblue;
    font-size: 20px;
    cursor: pointer;
}

#print {
    font-family: Verdana,
        Geneva, Tahoma, sans-serif;
    color: #000099;
    font-size: 30px;
    font-weight: bold;
}

#main {
    text-align: center;
}

#ins {
    font-family: Verdana, Geneva,
        Tahoma, sans-serif;
    color: #660022;

}

.img {
    height: 250px;
    width: 280px;
}