import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { 
  StyleSheet, 
  Text, 
  View,
  FlatList,
} from 'react-native';

import CategoryListItem from "../components/CategoryListItem.js";    //import CategoryListItem
import img_qr from  '../image/qrcode_dev.png';


export default class Categories extends React.Component {
  //  https://reactnavigation.org/docs/stack-navigator/
  static navigationOptions = {
      title: 'Home'
  };



  constructor(props){
    super(props);
    this.state = {
      //array
      categories: [ 
        { id: 1, name: 'Quét QRCode', img: img_qr},
      ]
    };
  }


  render()
  {
    const {navigation} = this.props; //khai bao navigation = props,  doc du lieu
    const {categories} = this.state; //khai bao categories = state
    return (
      <View>
        {/*FlatList data={array}  */}
        <FlatList data={categories}
          // renderItem={({ object })}
          renderItem={({ item }) => 
            <CategoryListItem 
                category={item} 
                onPress={() => 
                  navigation.navigate('Category', {
                      categoryName: item.name, categoryImage: item.img
                })} //chuyen onPress qua props, //item dai dien cho category (truyen du lieu qua navigation)
            /> }
          keyExtractor={(item) => `${item.id}`}
          contentContainerStyle={styles.container}
        /> 

      </View>
      );
  }

}

const styles = StyleSheet.create({
  container: {
    paddingLeft: 16,
    paddingRight: 16,
    paddingTop: 16
  },
});
