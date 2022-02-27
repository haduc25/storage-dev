import React from 'react';
import { 
  StyleSheet, 
  Text, 
  View,
} from 'react-native';




export default class Category extends React.Component {
  static navigationOptions = ({ navigation }) => {
    return {
        title: navigation.getParam('categoryName')
    };
  };
  



  render(){
    return <View>
        <Text>Category</Text>
    </View>;
  }

}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'stretch', //alignItems: 'stretch' can le tran 2 ben
    backgroundColor: '#fff',
    justifyContent: 'center',
    paddingLeft: 16,
    paddingRight: 16,

  },
});
