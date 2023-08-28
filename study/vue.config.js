const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
    transpileDependencies: true,
    devServer: {
        //proxy: 'http://localhost:8080/'
        proxy:'https://localhost:5001'
    },

    // publicPath: process.env.NODE_ENV === 'production' ?
    //     '/public/' :
    //     '/'
})